using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Простой калькулятор
            try
            {
                Console.WriteLine("Вас приветсвует наипростейший калькулятор!\nДавай я покажу что умею, хоть и немного, так как пока что учусь.\n\nВведите первое число x ");
                decimal x = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("\nВведите второе число");
                decimal y = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("\nВыберите требуемую операцию из списка, указав её номер:\n    1 – сложение\n    2 – вычитание\n    3 – произведение    \n    4 – частное");
                Console.Write("Ваш выбор - ");
                int operation = Convert.ToInt32(Console.ReadLine());
                if (operation == 1)
                {
                    Console.WriteLine("\nРезультат действия = {0:f2}\n\nКруто, да!", x + y);
                }
                else
                {
                    if (operation == 2)
                    {
                        Console.WriteLine("\nРезультат действия = {0:f2}\n\nКруто, да!", x - y);
                    }
                    else
                    {
                        if (operation == 3)
                        {
                            Console.WriteLine("\nРезультат действия = {0:f2}\n\nКруто, да!", x * y);
                        }
                        else
                        {
                            if (operation == 4)
                            {
                                Console.WriteLine("\nРезультат действия = {0:f2}\n\nКруто, да!", (x / y));
                            }
                            else
                            {
                                Console.WriteLine("\nВведен недопустимый код операции\n\nПрошу повнимательней! Можно выбрать 1 или 2 или 3 или 4. Другого не дано!");
                            }
                        }
                    }
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nУпс! Что-то пошло не так:");
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
