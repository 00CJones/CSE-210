class Account {

    private float balance = 12;

    public float Withdraw()
    {
        Console.WriteLine("How much would you like to withdraw?");
        float amount = float.Parse(Console.ReadLine());

        if (amount > balance)
        {
            return 0;
        }
        this.balance -= amount; //this.balance refers to balance in this class. Not necessary in C# but useful

        return amount;

    }

    public float GetAccountBalance()
    {
        return this.balance;
    }
}