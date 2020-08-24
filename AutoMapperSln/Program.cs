namespace AutoMapperSln
{
    using AutoMapper;
    using AutoMapperSln.Automapper;
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            new Program().AutoMapperDemo();
            Console.ReadKey();
        }

        private void AutoMapperDemo()
        {
            while (choice.Equals("y"))
            {
                Console.WriteLine("=====Auto Mapper=====");
                Console.WriteLine("1. Similar type Auto Mapping");
                Console.WriteLine("2. Dissimilar type Auto Mapping");
                Console.WriteLine("n. Dissimilar type Auto Mapping");
                choice = Console.ReadLine();
                Console.Clear();
                switch (choice)
                {
                    case "1":
                        AuthorDemo.SMapper();
                        break;

                    case "2":
                        AuthorDemo.DMapper();
                        break;

                    case "n":
                        Environment.Exit(0);
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Enter y to continue or n to exit");
                choice = Console.ReadLine();
            }
        }

        private string choice = "y";
    }
}
