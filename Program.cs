/*
Programmer: Alaeldeen Alkenani
Date: 9/17/2020
Discription: This C# Console application code demonstrates the use of
             a conditional statement after getting input from users
             on what grade they expect to receive in ISM 4300.
*/

using System;

namespace Project_2b_ISM4300_Grade_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What grade you expect to get in ISM 4300?");

                // This variable will gather data from user input.
                string Input = Console.ReadLine();

                /* 
                   This variable will be used to store the grade 
                   after the input variable is parsed to integer.
                */
                int Grade = int.Parse(Input);

                /* 
                   This IF/ELSE IF/ELSE statement is used to conditionally
                   test the users input. Various letter grades are available
                   depending on the integer grade entered by the user.
                */
                if (Grade >= 90 && Grade <= 100)
                {
                    Console.WriteLine("You expect to receive a grade of A.");
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey(true);
                }

                else if (Grade >= 80 && Grade <= 89)
                {
                    Console.WriteLine("You expect to receive a grade of B.");
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey(true);
                }

                else if (Grade >= 70 && Grade <= 79)
                {
                    Console.WriteLine("You expect to receive a grade of C.");
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey(true);
                }

                else if (Grade >= 60 && Grade <= 69)
                {
                    Console.WriteLine("You expect to receive a grade of D.");
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey(true);
                }

                else if (Grade >= 0 && Grade <= 59)
                {
                    Console.WriteLine("You expect to receive a grade of F.");
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey(true);
                }

                else
                {
                    Console.WriteLine("Enter an integer 0 to 100.");
                    Console.WriteLine("Press any key to exit the application.");
                    Console.ReadKey(true);
                }
            } // End of try.

            catch
            {
                Console.WriteLine("You must enter an integer value. You can't type symbols or letters.");
                Console.WriteLine("Press any key to exit the application.");
                Console.ReadKey(true);
            } // End of catch
        } // End of main
    } // End of profram
} // End of Namepace
