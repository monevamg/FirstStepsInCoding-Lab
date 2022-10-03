using System;

namespace _07.ProjectsCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfArchitect = Console.ReadLine();
            int numberOfProjects = int.Parse(Console.ReadLine());

            int hoursRequired = numberOfProjects * 3;

            Console.WriteLine($"The architect {nameOfArchitect} will need {hoursRequired} hours to complete {numberOfProjects} project/s.");


        }
    }
}
