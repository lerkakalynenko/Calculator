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
            AdvancedCalc advancedCalc = new AdvancedCalc();
            Console.WriteLine("Введите какой калькулятор вы хотите использовать, если обычный, то \n" +
                              "введите 'o', если инженерный - 'a', выход - exit");
            string calc = Console.ReadLine();
            if (calc == "exit")
            {
                return;
                
            }
            string str = " ";
            while (true)
            {

                if (calc == "o")
                {
                    Console.WriteLine("Введите 2 числа через пробел, выход - exit ");
                    str = Console.ReadLine();
                    if (str == "exit")
                    {
                        return;
                    }

                    string[] array = str.Split(' ', (char) StringSplitOptions.RemoveEmptyEntries);

                    ordinaryCalc.Number1 = double.Parse(array[0]);
                    ordinaryCalc.Number2 = double.Parse(array[1]);
                    Console.WriteLine("Введите операцию, которую вы хотите произвести над числами: \n" +
                                      "+ => сложение; - => вычитание; * => умножение; / => деление"
                    );

                    string operation = Console.ReadLine();

                    if (operation == "+")
                    {
                        Console.WriteLine(
                            $"{ordinaryCalc.Number1} + {ordinaryCalc.Number2} = {ordinaryCalc.Add()} ");
                        Console.WriteLine();
                    }

                    else if (operation == "-")
                    {
                        Console.WriteLine(
                            $"{ordinaryCalc.Number1} - {ordinaryCalc.Number2} = {ordinaryCalc.Sub()} ");
                        Console.WriteLine();
                    }

                    else if (operation == "*")
                    {
                        Console.WriteLine(
                            $"{ordinaryCalc.Number1} * {ordinaryCalc.Number2} = {ordinaryCalc.Mul()} ");
                        Console.WriteLine();

                    }

                    else if (operation == "/")
                    {
                        if (ordinaryCalc.Number2 == 0)
                        {
                            Console.WriteLine("Ошибка! Деление на ноль невозможно!!!");
                            Console.WriteLine();
                        }

                        Console.WriteLine(
                            $"{ordinaryCalc.Number1} / {ordinaryCalc.Number2} = {ordinaryCalc.Div()} ");
                        Console.WriteLine();
                    }
                }
                else if (calc == "a")
                {
                    Console.WriteLine("Введите число, косинус которого вы хотите узнать");
                    str = Console.ReadLine();
                    if (str == "exit")
                    {
                        return;
                    }

                    advancedCalc.Number1 = double.Parse(str);
                    if (advancedCalc.Number1 >= 0 && advancedCalc.Number1 <= 360)
                    {
                    

                    Console.WriteLine($"cos({advancedCalc.Number1}) = {advancedCalc.Cos()}");
                    Console.WriteLine();
                }
                    else
                    {
                        Console.WriteLine("Косинус можно вычислить в пределах только от 0 до 360");
                    }
            }
                    
                }
            }
        
        }
        
    }

