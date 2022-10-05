using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeeSharpo
{
    class Program
    {
        static void input(string[] arr)
        {
            Console.Write("Your First Name: ");
            arr[0] = Console.ReadLine();
            Console.Write("Your Last Name: ");
            arr[1] = Console.ReadLine();
            Console.Write("Your Date of Birth: ");
            arr[2] = Console.ReadLine();
            Console.WriteLine("Your Address- ");
            Console.Write("Line 1: ");
            arr[3] = Console.ReadLine();
            Console.Write("Line 2: ");
            arr[4] = Console.ReadLine();
            Console.Write("Your City Name: ");
            arr[5] = Console.ReadLine();
            Console.Write("Your State Name: ");
            arr[6] = Console.ReadLine();
            Console.Write("Your Zip Code: ");
            arr[7] = Console.ReadLine();
            Console.Write("Your Country: ");
            arr[8] = Console.ReadLine();
        }

        static void change(string[] arr)
        {
            Console.WriteLine("What would you like to change?");
            Console.Write(" 1. Address Line 1 \n 2. Address Line 2 \n 3. City \n 4. Country \n- ");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write("Enter the new Address Line 1: ");
                    arr[3] = Console.ReadLine();
                    Console.WriteLine("Information changed!");
                    print(arr);
                    break;
                case "2":
                    Console.Write("Enter the new Address Line 2: ");
                    arr[4] = Console.ReadLine();
                    Console.WriteLine("Information changed!");
                    print(arr);
                    break;
                case "3":
                    Console.Write("Enter the new City name: ");
                    arr[5] = Console.ReadLine();
                    Console.WriteLine("Information changed!");
                    print(arr);
                    break;
                case "4":
                    Console.Write("Enter the new Country name: ");
                    arr[8] = Console.ReadLine();
                    Console.WriteLine("Information changed!");
                    print(arr);
                    break;
                default:
                    Console.WriteLine("Invalid input. Try again!");
                    change(arr);
                    break;
            }

        }

        static void print(string[] arr)
        {
            Console.WriteLine("Your First Name: {0}", arr[0]);
            Console.WriteLine("Your Last Name: {0}", arr[1]);
            Console.WriteLine("Your Date of Birth: {0}", arr[2]);
            Console.WriteLine("Your Address- ");
            Console.WriteLine("Line 1: {0}", arr[3]);
            Console.WriteLine("Line 2: {0}", arr[4]);
            Console.WriteLine("Your City Name: {0}", arr[5]);
            Console.WriteLine("Your State Name: {0}", arr[6]);
            Console.WriteLine("Your Zip Code: {0}", arr[7]);
            Console.WriteLine("Your Country: {0}", arr[8]);
        }

        static void question2(string[] arr)
        {
            Console.Write("Would you like to print the information? (Y/N): ");
            string opt2 = Console.ReadLine();
            if (opt2 == "Y")
            {
                print(arr);
            }
            else if (opt2 == "N")
            {
                Console.WriteLine("Thank You for your Information!");
            }
            else
            {
                Console.WriteLine("Invalid input. Try again!");
                question2(arr);
            }
        }


        static void Main(string[] args)
        {
            string[] student_1 = new string[9];
            input(student_1);
            Console.Write("Would you like to Change any of the given information? (Y/N): ");
            if (Console.ReadLine() == "Y")
            {
                change(student_1);
            }
            else
            {
                question2(student_1);
            }
        }
    }
}
