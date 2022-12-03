using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0;
            double y = 0;
            
            Console.WriteLine("Вас приветствует калькулятор!");

            try
            {
                Console.Write("Введите первое целое число. Х=");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите второе целое число. Y=");
                y = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.Write("Ошибка!");
                 Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            
            Console.WriteLine("Введите код операции: \n 1-сложение \n 2-вычитание \n 3-произведение \n 4-частное");
            Console.Write("Ваш выбор: ");
            double act = Convert.ToDouble(Console.ReadLine());

            switch (act)
            {
                case 1:
                    {
                        double result = x + y;
                        Console.WriteLine("Результат = {0}", result);
                        break;
                    }
                case 2:
                    {
                        double result = x - y;
                        Console.WriteLine("Результат = {0}", result);
                        break;
                    }
                case 3:
                    {
                        double result = x * y;
                        Console.WriteLine("Результат = {0}", result);
                        break;
                    }
                case 4:
                    {
                        
                            double result = x / y;
                            Console.WriteLine("Результат = {0}", result);
                            break;

                    }
                default:
                    {
                        Console.WriteLine("Нет операции с указанным номером!");
                        break;
                    }

            }
            Console.ReadKey();
        }
    }
}
