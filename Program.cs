using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    internal class Point
    {
        
        public string X { get; set; }
        public string Y { get; set; }

        public Point(string x, string y)
        {
            this.X = x;
            this.Y = y;
        }

        public Point()
        {
            this.X = "0";
            this.Y = "0";
        }

        public string ShowData()
        {
            string text = $"Model {X} ve {Y} ";
            return text;
        }
    
    }

    //===================================================================

    internal class Counter
    {
        public int Min { get; set; } = 0;
        public int Max { get; set; } = 100;
        public int CurrentData { get; set; }

        public void Count()
        {
            for (int i = Min; i <= Max; i++)
            {
                CurrentData = i;
                Console.WriteLine(CurrentData);
            }
        }
    }
    internal class CounterDataa
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();
            counter.Count();

            Console.ReadLine();
        }
    }
    //===================================================================


    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("------------------");
                Console.WriteLine("    Calculator    ");
                Console.WriteLine("------------------");

                Console.Write("Number 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Number 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("------------------");
                Console.WriteLine("+ : Toplama");
                Console.WriteLine("- : Çixma");
                Console.WriteLine("* : Vurma");
                Console.WriteLine("/ : Bölme");
                Console.WriteLine("------------------");
                Console.Write("Seçiminizi daxil edin( + , * , - , / ): ");


                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine("------------------");
                        Console.WriteLine($"Cavab: {num1} + {num2} = " + result);
                        Console.WriteLine("------------------");
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine("------------------");
                        Console.WriteLine($"Cavab: {num1} - {num2} = " + result);
                        Console.WriteLine("------------------");
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine("------------------");
                        Console.WriteLine($"Cavab: {num1} * {num2} = " + result);
                        Console.WriteLine("------------------");
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine("------------------");
                        Console.WriteLine($"Cavab: {num1} / {num2} = " + result);
                        Console.WriteLine("------------------");
                        break;
                    default:
                        Console.WriteLine("Bele bir seçim mövcud deyil!");
                        break;
                }
                Console.Write("Davam etmek isteyirsiniz ? (Y = yes, N = No): ");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Bye!");
            Console.ReadKey();
        }
    }

}
