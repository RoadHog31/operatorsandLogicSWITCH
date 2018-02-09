using System;

namespace operatorsandLogicSWITCH
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wolf Academy Opertors and Logic SWITCH exercise. 
            //App program to allow the user to enter two integers and add or subtract them and display the answer on screen.
            //First line asking the user ti input their first integer. 
            Console.WriteLine("Please enter a number then press return: ");
            int number1 = int.Parse(Console.ReadLine());
            //Second line asking the user to select an operator.
            Console.WriteLine("Please enter either (+ - / *) then press return: ");
            string oper = Console.ReadLine();
            //Third line asking the user to input their second integer. 
            Console.WriteLine("Please enter a 2nd number then press return: ");
            int number2 = int.Parse(Console.ReadLine());

            //integer variables utilising operators for the calculations. 
            int add = number1 + number2;
            int sub = number1 - number2;
            int divide = number1 / number2;
            int multi = number1 * number2;

            //SWITCH statement for the desired operator. 
            switch (oper)
            {
                case "+":
                Console.WriteLine("Your Answer is: " + add);
                break;
                case "-":
                Console.WriteLine("Your Answer is: " + sub);
                break;
                case "/":
                Console.WriteLine("Your Answer is: " + divide);
                break;
                case "*":
                Console.WriteLine("Your Answer is: " + multi);
                break;
                default:
                Console.WriteLine("Sorry please try again! ");
                break;
             }
             Console.ReadLine();
        }
    }
}
