using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Rectangle 
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = string.Empty;
            bool validMenuSelect = false;

            while (validMenuSelect == false)
            {
                Console.WriteLine("1. Get Length of Rectangle");
                Console.WriteLine("2. Change Length of Rectangle");
                Console.WriteLine("3. Get Width of Rectangle");
                Console.WriteLine("4. Change Width of Rectangle");
                Console.WriteLine("5. Get Perimeter of Rectangle");
                Console.WriteLine("6. Get Area of Rectangle");
                Console.WriteLine("7. Exit");

                Console.WriteLine("Please select from the options above by entering the corresponding number.");
                userInput = Console.ReadLine();

                if (userInput != "1" &&
                    userInput != "2" &&
                    userInput != "3" &&
                    userInput != "4" &&
                    userInput != "5" &&
                    userInput != "6" &&
                    userInput != "7")
                {
                    Console.WriteLine("Please enter a valid input.");
                }
                else
                {
                    validMenuSelect = true;
                }
            }
            Console.WriteLine();
            return int.Parse(userInput);
        }

        public static int ValidateUserInput(string rectSide)
        {
            int number = 1;
            bool isValid = false;

            while (isValid == false)
            {
                Console.WriteLine("Please enter the {0} of your rectangle :", rectSide);
                string userInput = Console.ReadLine();
                Console.WriteLine();

                bool result = int.TryParse(userInput, out number);

                if (result == false)
                {
                    Console.WriteLine("Please enter a valid input.");
                }
                else if (number <= 0)
                {
                    Console.WriteLine("Please enter an integer greater than 0");
                }
                else
                {
                    isValid = true;
                    Console.WriteLine("The {0} of your rectangle is now {1} unit(s).", rectSide, number);
                }
            }
            return number;
        }
        static void Main(string[] args)
        {
            int length;
            int width;
            Rectangle r = new Rectangle();

            length = ValidateUserInput("length");
            width = ValidateUserInput("width");
            Console.WriteLine("Your Rectangle is of {0} x {1} unit(s).", length, width);

            Rectangle rect = new Rectangle(length, width);
            r = rect;

            int selection = ValidateMenuSelection();
            while (selection != 7)
            {
                int result;
                switch (selection)
                {
                    case 1:
                        Console.WriteLine("Length is {0} unit(s).", r.GetLength());
                        break;

                    case 2:
                        result = ValidateUserInput("length");
                        r.SetLength(result);
                        break;

                    case 3:
                        Console.WriteLine("Width is {0} unit(s).", r.GetWidth());
                        break;

                    case 4:
                        result = ValidateUserInput("width");
                        r.SetWidth(result);
                        break;
                    case 5:
                        Console.WriteLine("The perimeter of rectangle of {0} x {1} unit(s) is : {2}", r.GetLength(), r.GetWidth(), r.GetPerimeter());
                        break;
                    case 6:
                        Console.WriteLine("The area of rectangle of {0} x {1} unit(s) is : {2}", r.GetLength(), r.GetWidth(), r.GetArea());
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input from the menu");
                        break;
                }
                selection = ValidateMenuSelection();
            }
        }
    }
}

       
