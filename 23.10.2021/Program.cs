using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._10._2021
{


    class Program
    {

        static void Main(string[] args)
        {

            BankDeal schet = new BankDeal();
            Console.WriteLine("Задание 1");
            Console.WriteLine("\nСчета");

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nКакую операцию хотите произвести? \n Чтобы заполнить данные нажмите 1 \n Чтобы вывести данные нажмите 2 \n Чтобы снять со счета нажмите 3 \n Чтобы пополнить баланс нажмите 4\n Чтобы перевести с одного счета на другой нажмите 5\n Чтобы закрыть программу нажмите 6");

                int vvod;

                while ((!int.TryParse(Console.ReadLine(), out vvod) || vvod > 5 || vvod < 0))
                {
                    Console.WriteLine("Ошибка ввода! Введите нужное число");
                }

                switch (vvod)
                {
                    case 1:
                        schet.Filling();
                        schet.ShowInformation();
                        break;
                    case 2:
                        schet.ShowInformation();
                        schet.ShowInformation();
                        break;
                    case 3:
                        schet.GetFrom();
                        schet.ShowInformation();
                        break;
                    case 4:
                        schet.AddMore();
                        schet.ShowInformation();
                        break;
                    case 5:
                        Console.WriteLine("На какой счет 1(Текущий) или 2(Сберегательный)");
                        int n;
                        while ((!int.TryParse(Console.ReadLine(), out n) || n > 3 || n < 0))
                        {
                            Console.WriteLine("Ошибка ввода! Введите число");

                        }
                        Console.WriteLine("Введите сумму ");
                        decimal sum;
                        while (!decimal.TryParse(Console.ReadLine(), out sum))
                        {
                            Console.WriteLine("Ошибка ввода! Введите число");
                        }
                        
                        schet.Transfer( ref schet, sum);
                        schet.ShowInformation();
                        break;
                    case 6:
                        flag = false;
                        break;


                }
            }
        }
    }
}

