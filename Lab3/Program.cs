using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput, square, cube, i;
            string powerTable, tableHeader;
            bool Exit = false; //bool used for entire program
            bool AnotherTry; //bool used for running program again
            char doAgain;

            while (Exit == false)
            {
                //input
                Console.WriteLine("Hello, welcome to Lab 3! \nPlease enter an integer.");

                //validation of input, if valid userInput = number of times loop will run
                if (int.TryParse(Console.ReadLine(), out userInput))
                {
                    AnotherTry = true; //assigned to enter while loop when requesting to try again

                    Console.Clear();
                    Console.WriteLine("Thank you!");
                    System.Threading.Thread.Sleep(700);
                    Console.Clear();

                    //tableHeader formatted and printed once for the header, and again for the dividing lines
                    tableHeader = String.Format("{0,-10} {1,-10} {2,-10}", "Number", "Squared", "Cubed");
                    Console.WriteLine(tableHeader);
                    tableHeader = String.Format("{0,-10} {1,-10} {2,-10} \n", "=======", "=======", "=======");
                    Console.WriteLine(tableHeader);

                    for (i = 1; i <= userInput; i++)
                    {
                        //calculate sq and cu
                        square = i * i;
                        cube = i * i * i;

                        //specifies the format to print the number, square, and cube, then prints on a new line
                        powerTable = String.Format("{0,-10} {1,-10} {2,-10} \n", i, square, cube);
                        Console.WriteLine(powerTable);
                    }

                    //input to ask user to continue or not.
                    while (AnotherTry == true)
                    {
                        System.Threading.Thread.Sleep(500);
                        Console.WriteLine("Would you like to run again? (Y/N)");

                        //validate input
                        if (char.TryParse(Console.ReadLine(), out doAgain))
                        {
                            if (doAgain == 'y' || doAgain == 'Y') //exit this loop if yes
                            {
                                Console.Clear();
                                Console.WriteLine("Here we go!");
                                System.Threading.Thread.Sleep(500);
                                Console.Clear();
                                AnotherTry = false;
                            }
                            else if (doAgain == 'n' || doAgain == 'N') //exit this loop AND outside loop if no
                            {
                                Console.Clear();
                                Console.WriteLine("Goodbye! Press the enter key to exit.");
                                AnotherTry = false;
                                Exit = true;
                                Console.Read();
                            }
                            else //print error message and stay in loop for an unrecognized user input
                            {
                                Console.Clear();
                                Console.WriteLine("Input not understood.");
                                System.Threading.Thread.Sleep(500);
                            }
                        }
                    }
                }
                else //print message but stay in loop if user enters non-integer
                {
                    Console.Clear();
                    Console.WriteLine("Not a valid integer. Please try again.");
                    System.Threading.Thread.Sleep(700);
                    Console.Clear();
                }
            }

        }
    }
}
