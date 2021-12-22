using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Вас приветствует калькулятор!");
            try
            {
                Console.Write($"Введите первое число. X = ");
                int firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Введите второе число. Y = ");
                int secondNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите код операции:\n     1 - сложение\n     2 - вычитание\n     3 - произведение\n     4 - деление");
                Console.Write("Ваш выбор: ");
                int cmd = Convert.ToInt32(Console.ReadLine());
                //try
                //{
                    switch (cmd)
                    {
                        case 1:
                            {
                                Console.WriteLine("Результат: {0}", firstNumber + secondNumber);
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Результат: {0}", firstNumber - secondNumber);
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("Результат: {0}", firstNumber * secondNumber);
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("Результат: {0}", firstNumber / secondNumber);
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Нет операции с указанным номером");
                                break;
                            }
                    }
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine(ex.Message);
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
