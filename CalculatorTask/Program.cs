using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Calculator calculator = new Calculator();

            Console.WriteLine("Enter first number :");
            int num1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number :");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Sum
            double sumResult = calculator.sum(num1, num2);
            Console.WriteLine(sumResult);

            // Sub
            double subResult = calculator.sub(num1, num2);
            Console.WriteLine(subResult);

            // multi
            double multiResult = calculator.multi(num1, num2);
            Console.WriteLine(multiResult);

            // div 
            double divResult = calculator.div(num1, num2);
            Console.WriteLine(divResult);
        }
    }
}
