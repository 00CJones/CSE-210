using System;
using System.Collections.Frozen;

class Program
{
    static void Main(string[] args)
    {
        // Person fred = new Person();
        // fred.givenName = "Fred";
        // fred.familyName = "Flinstone";

        // Person steve = new Person();
        // steve.givenName = "Steve";
        // steve.familyName = "Minecraft";

        // fred.EasternStyleName();
        // steve.WesternStyleName();

        Job job1 = new Job();
        job1.jobTitle = "Software Engineer";
        job1.company = "Microsoft";
        job1.startYear = 1995;
        job1.endYear = 2000;
        //job1.Display();

        Job job2 = new Job();
        job2.jobTitle = "Electrical Engineer";
        job2.company = "Intel";
        job2.startYear = 2008;
        job2.endYear = 2018;        
        //job2.Display();

        Resume resume1 = new Resume();
        resume1.name = "Joe Mama";
        resume1.myListOfJobs.Add(job1);
        resume1.myListOfJobs.Add(job2);
        resume1.Display();
    }
}