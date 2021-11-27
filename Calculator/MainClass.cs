using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using Console = System.Console;

namespace Calculator
{
    public class MainClass

    {
        static void Main(string[] args)
        {
            OrdinaryCalc ordinaryCalc = new OrdinaryCalc();
            Console.WriteLine("Введите какой калькулятор вы хотите использовать, если обычный, то \n" +
                              "введите 'o', если инженерный - 'a'");
            string calc = Console.ReadLine();

            string str = " ";
            while (str != "exit")
            {
               
                if (calc == "o")
                {
                    Console.WriteLine("Введите 2 числа через пробел ");
                    str = Console.ReadLine();
                    string[] array = str.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);

                    ordinaryCalc.Number1 = double.Parse(array[0]);
                    ordinaryCalc.Number2 = double.Parse(array[1]);
                    Console.WriteLine("Введите операцию, которую вы хотите произвести над числами: \n" +
                                      "+ => сложение; - => вычитание; * => умножение; / => деление"
                    );

                    string operation = Console.ReadLine();

                    if (operation == "+")
                    {
                        Console.WriteLine($"{ordinaryCalc.Number1} + {ordinaryCalc.Number2} = {ordinaryCalc.Add()} ");
                    }

                   else if (operation == "-")
                    {
                        Console.WriteLine($"{ordinaryCalc.Number1} - {ordinaryCalc.Number2} = {ordinaryCalc.Sub()} ");
                    }

                   else if (operation == "*")
                    {
                        Console.WriteLine($"{ordinaryCalc.Number1} * {ordinaryCalc.Number2} = {ordinaryCalc.Mul()} ");

                    }

                    else if (operation == "/")
                    {
                        if (ordinaryCalc.Number2 == 0)
                        {
                            Console.WriteLine("Ошибка! Деление на ноль невозможно!!!");
                        }
                        Console.WriteLine($"{ordinaryCalc.Number1} / {ordinaryCalc.Number2} = {ordinaryCalc.Div()} ");
                    }

                }
            }

        }


    }
}
