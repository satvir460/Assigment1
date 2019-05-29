using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnet1

{
    class Program
    {
        public static int ValidationMenuSelection()
        {
            string userInput = "";
            bool validMenuSelect = false;

            while (validMenuSelect == false)
            {
                Console.WriteLine("1 = Get Rectangle Length");
                Console.WriteLine("2 = Change Rectangle lenght");
                Console.WriteLine("3 = Get Rectangle Width");
                Console.WriteLine("4 = Change Rectangle Width");
                Console.WriteLine("5 = Get Rectangle Permeter");
                Console.WriteLine("6 = Get Rectangle Area");
                Console.WriteLine("7 = Exit\n");

                Console.WriteLine("Select an option by enter a number:\n");
                userInput = Console.ReadLine();

                if (userInput != "1" &&
                    userInput != "2" &&
                    userInput != "3" &&
                    userInput != "4" &&
                    userInput != "5" &&
                    userInput != "6" &&
                    userInput != "7")
                {
                    Console.WriteLine("Not valid option, Try again: \n");
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
                Console.WriteLine($"Enter the {rectSide} of Rectangle:");
                string userInput = Console.ReadLine();
                Console.WriteLine();
                bool result = int.TryParse(userInput, out number);
                if (result == false)
                {
                    Console.WriteLine("Not valid option, Try again\n");
                }
                else if (number <= 0)
                {
                    Console.WriteLine("Enter a number which must be greater than zero");
                }
                else if (number > 0)
                {
                    isValid = true;
                    Console.WriteLine($"The {rectSide} rectangle is now {number}\n");

                }
            }
            return number;
        }
        static void Main(string[] args)
        {
            Rectangle c = new Rectangle();
            bool validRecSelect = false;
            string RectangleSelection;
            int selection;

            while (validRecSelect == false)
            {
                Console.WriteLine("1 = Use default values of length=1 and width=1\n");
                Console.WriteLine("2 = Give your length and width\n");
                Console.WriteLine("Choose a menu item to begin:");
                RectangleSelection = Console.ReadLine();
                Console.WriteLine();

                if (RectangleSelection != "1" && RectangleSelection != "2")
                {
                    Console.WriteLine("Not valid option, Try again.\n");
                }
                else if (int.Parse(RectangleSelection) == 1)
                {
                    validRecSelect = true;
                    Random random = new Random();
                    int length = 1;
                    int width = 1;

                    Console.WriteLine($" Default length is {length} and width is {width}.\n");
                    Rectangle customRecta = new Rectangle(length, width);
                    c = customRecta;

                }
                else if (int.Parse(RectangleSelection) == 2)
                {
                    validRecSelect = true;

                    int length;
                    int width;

                    length = ValidateUserInput("length");
                    width = ValidateUserInput("width");

                    Console.WriteLine($"Custom length is {length} and width is {width}.\n");
                    Rectangle customRecta = new Rectangle(length, width);
                    c = customRecta;
                }
            }


            selection = ValidationMenuSelection();

            while (selection != 7)
            {
                int result;

                switch (selection)
                {
                    case 1:
                        Console.WriteLine($"Length : {c.GetLength()}\n");
                        break;
                    case 2:
                        result = ValidateUserInput("length");
                        c.SetLength(result);
                        break;
                    case 3:
                        Console.WriteLine($"Width : {c.GetWidth()}\n");
                        break;
                    case 4:
                        result = ValidateUserInput("width");
                        c.SetWidth(result);
                        break;
                    case 5:
                        Console.WriteLine($"The Perimeter of {c.GetLength()} and {c.GetWidth()} is: {c.GetPerimeter()}\n");
                        break;
                    case 6:
                        Console.WriteLine($"The Area of {c.GetLength()} and {c.GetWidth()} is:{c.GetArea()}\n");
                        break;
                    default:
                        break;
                }

                selection = ValidationMenuSelection();

            }

        }

    }
}