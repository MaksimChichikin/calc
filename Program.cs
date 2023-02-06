using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator2018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число 1:");
            double first = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите чмсло 2:");
            double second = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Выберите операцию:");
            string  operation =Convert.ToString(Console.ReadLine());
            double res = 0;
            switch (operation)
            {
                case "+":
                   res = Functions.plus(first,second);
                   
                    break;
                case "-":
                    res =Functions.minus(first, second);
                    break;
                case "*":
                    res = Functions.multiply(first, second);
                    break;
                case "/":
                    res =Functions.divide(first, second);
                    break;
                    default:
                    Console.WriteLine("ошибка");
                    break;
            }
            Console.WriteLine($"Результат:{res}");
            Console.ReadKey();

        }
    }
    
   public  class Functions
    {
        public static double plus(double first, double second)
        {
  
            double result = first + second;
            return result;
        }
        public static double minus(double first, double second) 
        {
            double result = first - second;
            return result;
        } 
        public static double multiply(double first, double second) 
        {
            double result = first * second;
            return result;

        }
        public static double divide(double first, double second)
        {
            double result = first / second;
            return result;
        }
    } 
}
