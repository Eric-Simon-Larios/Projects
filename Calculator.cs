using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double answer;
            string response;
            response = "Y";
            answer = 0;
            // To loop the whole program
            while (response=="y" || response=="Y")
            {
                Console.Write("Enter a number: ");
                string fnum = Console.ReadLine();

                Console.Write("Enter a number: ");
                string snum = Console.ReadLine();

                Console.WriteLine("Operators: + - / *");
                Console.Write("Pick a operator: ");
                string oper = Console.ReadLine();

                double num1 = Convert.ToDouble(fnum);
                double num2 = Convert.ToDouble(snum);

                // Below are the solutions to determine which operator is used and what will happen if one of the conditions were satisfied

                if (oper == "+")
                {
                    answer = num1 + num2;
                }
                else if (oper == "-")
                {
                    answer = num1 - num2;
                }
                else if (oper == "*")
                {
                    answer = num1 * num2;
                }
                else if (oper == "/")
                {
                    answer = num1 / num2;
                }
                else
                {
                    Console.WriteLine("There is no such operator");
                    Console.Write("Do you want to try again? Y/N: ");
                    response = Console.ReadLine();
                    continue;
                }
                Console.WriteLine(num1 + " " + oper + " " + num2 + " = " + answer);

                Console.Write("Do you want to try again? Y/N: ");
                response=Console.ReadLine();
            }
           
        }
    }
}
