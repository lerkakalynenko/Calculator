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
            
            Console.WriteLine("Введите какой калькулятор вы хотите использовать, если обычный, то \n" +
                              "введите 'o', если инженерный - 'a'");
            string calc = Console.ReadLine();

            string str = " ";
            while (str != "exit")
            {
                Console.WriteLine("Введите 2 числа через пробел");
                str = Console.ReadLine();
                string[] array = str.Split(' ',(char) StringSplitOptions.RemoveEmptyEntries);
                
                int number1 = int.Parse(array[0]);
                int number2 = int.Parse(array[1]);
                if (calc == "o")
                {
                    Console.WriteLine("Введите операцию, которую вы хотите произвести над числами: \n" +
                                      "+ => сложение; - => вычитание; * => умножение; / => деление"
                    );

                    string operation = Console.ReadLine();


                }
            }

        }

        
    }
}
