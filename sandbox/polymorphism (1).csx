using Internal;

abstract class Employee
{
    public string name;

    public Employee(string name)
    {
        this.name = name;
    }

    public abstract decimal CalculatePay();
}

class SalaryEmployee : Employee
{
    protected decimal annualSalary;

    public SalaryEmployee(string name, double annualSalary) : base(name)
    {
        this.annualSalary = (decimal) annualSalary;
    }

    public override decimal CalculatePay()
    {
        return annualSalary / 26; // Bi-weekly pay
    }
}

class HourlyEmployee : Employee
{
    protected decimal hourlyRate;
    protected int hoursWorked;

    public HourlyEmployee(string name, double hourlyRate, int hoursWorked) : base(name)
    {
        this.hourlyRate = (decimal) hourlyRate;
        this.hoursWorked = hoursWorked;
    }

    public override decimal CalculatePay()
    {
        return (hourlyRate * hoursWorked) * 2; // Bi-weekly pay
    }
}

SalaryEmployee salaryEmployee = new SalaryEmployee("John", 96000.13);
HourlyEmployee hourlyEmployee = new HourlyEmployee("Jane", 13.50, 40);

Console.WriteLine($"{salaryEmployee.name} makes ${salaryEmployee.CalculatePay():N2} bi-weekly.");
Console.WriteLine($"{hourlyEmployee.name} makes ${hourlyEmployee.CalculatePay():N2} bi-weekly.");