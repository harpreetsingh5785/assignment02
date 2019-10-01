using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Program
    {
        public static int validateTriangleSideA()
        {
            int number = 1;
            bool isValidSideA = false;
            string sideA = "";
            while (isValidSideA == false)
            {
                Console.WriteLine("Enter Side A of the triangle");
                sideA = Console.ReadLine();
                bool result = int.TryParse(sideA, out number);
                if (result == false)
                {
                    Console.WriteLine("This is  not a valid input, please try again ");
                }
                else if (number < 0)
                {
                    Console.WriteLine("Side A can not be less than 0, please try again");
                }
                else
                {
                    isValidSideA = true;

                }
                Console.WriteLine("");
            }
            return int.Parse(sideA);
        }
        public static int validateTriangleSideB()
        {
            int number = 1;
            bool isValidSideB = false;
            string sideB = "";
            while (isValidSideB == false)
            {
                Console.WriteLine("Enter Side B of the triangle");
                sideB = Console.ReadLine();
                bool result = int.TryParse(sideB, out number);
                if (result == false)
                {
                    Console.WriteLine("This is  not a valid input, please try again ");
                }
                else if (number < 0)
                {
                    Console.WriteLine("Side B can not be less than 0, please try again");
                }
                else
                {
                    isValidSideB = true;

                }
                Console.WriteLine("");
            }
            return int.Parse(sideB);
        }
        public static int validateTriangleSideC()
        {
            int number = 1;
            bool isValidSideC = false;
            string sideC = "";
            while (isValidSideC == false)
            {
                Console.WriteLine("Enter Side C of the triangle");
                sideC = Console.ReadLine();
                bool result = int.TryParse(sideC, out number);
                if (result == false)
                {
                    Console.WriteLine("This is  not a valid input, please try again ");
                }
                else if (number < 0)
                {
                    Console.WriteLine("Side C can not be less than 0, please try again");
                }
                else
                {
                    isValidSideC = true;

                }
                Console.WriteLine("");
            }
            return int.Parse(sideC);
        }
        static void Main(string[] args)
        {

            bool isValidChoice = false;
            while (isValidChoice == false)
            {
                Console.WriteLine("Press 1 or 2 ");
                Console.WriteLine("1. Enter triangle dimensions.");
                Console.WriteLine("2. Exit");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    isValidChoice = true;
                    int sideA = validateTriangleSideA();
                    int sideB = validateTriangleSideB();
                    int sideC = validateTriangleSideC();

                    string message = TriangleSolver.Analyze(sideA, sideB, sideC);
                    Console.WriteLine(message);
                    Console.WriteLine("");
                    Console.WriteLine("Press any key to exit the program");
                    Console.ReadKey();

                }
                else if (choice == "2")
                {
                    isValidChoice = true;
                    Console.WriteLine("Program Now exiting");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("This is not valid input, Please Enter Valid number");
                }
                Console.WriteLine("");
            }

        }
    }
}
