using System;

namespace Triangle
{
    public class Program
    {

        static void Main(string[] args)
        {
            string cont;
            string userInput = string.Empty;
            bool Validmenuselect = false;
            string resultString = string.Empty;


            while (Validmenuselect == false)
            {
                do
                {
                    Console.WriteLine("1.Enter the triangle dimensions");
                    Console.WriteLine("2.Exit");
                    Console.WriteLine("Please select an option by entering a valid number from the ablove list");
                    userInput = Console.ReadLine();
                    if (userInput != "1" && userInput != "2")
                    {
                        Console.WriteLine("Please enter a Valid option");
                    }
                    else if (userInput == "2")
                    {

                        Console.WriteLine("Exiting from the program");
                        System.Environment.Exit(0);
                    }
                    else
                    {
                        Validmenuselect = true;
                        string side1, side2, side3;
                        int sideint1, sideint2, sideint3;
                        Console.WriteLine("Enter the first side");
                        side1 = Console.ReadLine();
                        Console.WriteLine("Enter the second side");
                        side2 = Console.ReadLine();
                        Console.WriteLine("Enter the third side");
                        side3 = Console.ReadLine();
                        if ((int.TryParse(side1, out sideint1)) && (int.TryParse(side2, out sideint2)) && (int.TryParse(side3, out sideint3)) && (sideint1 > 0) && (sideint2 > 0) && (sideint3 > 0))
                        {

                            Console.WriteLine(TriangleSolver.Analyze(sideint1, sideint2, sideint3));


                        }
                        else
                        {
                            Console.WriteLine("The given inputs doesnot form a triangle!!");
                        }


                    }

                    Console.WriteLine("Do you want to continue?:(Y/N)");
                    cont = Console.ReadLine();
                } while ((cont == "Y") || (cont == "y"));

            }



        }



    }

}
