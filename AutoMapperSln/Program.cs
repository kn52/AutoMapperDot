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
                Console.WriteLine("1. Auto Mapper");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AuthorDemo.AMapper();
                        break;
                }
            }
        }

        private string choice = "y";
    }
}
