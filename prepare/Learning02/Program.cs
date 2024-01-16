using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "General Surgeon";
        job1._company = "Hospital Los Pinos";
        job1._startYear = 2017;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "General Surgeon";
        job2._company = "Caja de la Banca Privada";
        job2._startYear = 2019;
        job2._endYear = 2021;

        Job job3 = new Job();
        job3._jobTitle = "General Surgeon";
        job3._company = "Hospital de Caranavi";
        job3._startYear = 2016;
        job3._endYear = 2017;

        //job1.DisplayJobDetails();
        //Console.WriteLine("");
        //Job2.DisplayJob();

        Resume myResume = new Resume();
        myResume._name = "Favio Callejas Flores";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);

        myResume.DisplayResume();
    }
}