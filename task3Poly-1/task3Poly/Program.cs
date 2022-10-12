using System;
using task3Poly;

namespace task3Poly
{


    class program
    {
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new ProfibilityCalculator());

            //Animals[] myFarm = new Animals[10]; // Creating an Array of [10]
            //for (int i = 0; i < 10; i++)
            //{
            // if (i <= 5)
            // {
            //myFarm[i] = new Cow(i + 100, i * 22.3);
            //}
            //else
            //{
            //myFarm[i] = new JerseyCow(i + 500, i * 100.5);
            //}
            //} // End of the loop
            //double tot = 0.0;
            //for (int i = 20; i >= 10; i--)
            //{
            // tot += myFarm[i - 11].getProf();
            //}
            //Console.WriteLine($"The total is: {getProf}");
            //return;
        }
    }
}
