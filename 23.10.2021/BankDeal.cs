using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._10._2021
{



    class BankDeal
    {
        enum bank
        {
            Текущий = 1,
            Сберегательный
        }

        private Guid number;
        private bank tip;
        private decimal balanceTek, balanceSb, value1, value2;


        public void Filling()
        {

            Console.WriteLine("Какой тип счета 1(Текущий) или 2(Сберегательный)");
            int n;
            while ((!int.TryParse(Console.ReadLine(), out n) || n > 3 || n < 0))
            {
                Console.WriteLine("Ошибка ввода! Введите число");
            }
            Console.WriteLine("Введите баланс");
            if (n == 1)

            {
                while (!decimal.TryParse(Console.ReadLine(), out balanceTek) || balanceTek < 0)
                {
                    Console.WriteLine("Ошибка ввода! Введите число");

                }
            }
            else
            {

                while (!decimal.TryParse(Console.ReadLine(), out balanceSb) || balanceSb < 0)
                {
                    Console.WriteLine("Ошибка ввода! Введите число");
                }


            }
            tip = (bank)(n);
            number = Guid.NewGuid();


        }

        public void ShowInformation()
        {
            Console.WriteLine("Какой тип счета 1(Текущий) или 2(Сберегательный)");
            int n;
            while ((!int.TryParse(Console.ReadLine(), out n) || n > 3 || n < 0))
            {
                Console.WriteLine("Ошибка ввода! Введите число");
            }
            tip = (bank)(n);

            if (n == 1)
            {
                Console.WriteLine($"Номер = {number} Тип = {tip}  Баланс = {balanceTek}");
            }
            else
            {

                Console.WriteLine($"Номер = {number} Тип = {tip}  Баланс = {balanceSb}");
            }


        }


        public void AddMore()
        {

            Console.WriteLine("Какой тип счета 1(Текущий) или 2(Сберегательный)");
            int n;
            while ((!int.TryParse(Console.ReadLine(), out n) || n > 3 || n < 0))
            {
                Console.WriteLine("Ошибка ввода! Введите число");
            }



            if (n == 1)
            {
                Console.WriteLine("Введите сумму ");
                while (!decimal.TryParse(Console.ReadLine(), out value1) || value1 < 0)
                {
                    Console.WriteLine("Ошибка ввода! Введите число");
                }
                balanceTek += value1;
            }
            else
            {

                Console.WriteLine("Введите сумму ");
                while (!decimal.TryParse(Console.ReadLine(), out value2) || value2 < 0)
                {
                    Console.WriteLine("Ошибка ввода! Введите число");
                }
                balanceSb += value2;

            }


        }
        public void GetFrom()
        {

            Console.WriteLine("Какой тип счета 1(Текущий) или 2(Сберегательный)");
            int n;
            while ((!int.TryParse(Console.ReadLine(), out n) || n > 3 || n < 0))
            {
                Console.WriteLine("Ошибка ввода! Введите число");
            }
            if (n == 1)
            {
                Console.WriteLine("Введите сумму ");

                while (!decimal.TryParse(Console.ReadLine(), out value1) || balanceTek - value1 < 0)
                {
                    Console.WriteLine("Ошибка ввода! Введите число");
                }
                balanceTek -= value1;
            }
            else
            {
                Console.WriteLine("Введите сумму ");

                while (!decimal.TryParse(Console.ReadLine(), out value2) || balanceSb - value2 < 0)
                {
                    Console.WriteLine("Ошибка ввода! Введите число");
                }
                balanceSb -= value2;

            }

        }

        public void Transfer(ref BankDeal transf, decimal sum)
        {



            if ((int)transf.tip == 1)
            {
                Console.WriteLine("Введите сумму ");
                while (balanceSb - sum < 0)
                {
                    Console.WriteLine("Ошибка ввода! Введите число");
                    if (!decimal.TryParse(Console.ReadLine(), out sum))
                    {
                        Console.WriteLine("Ошибка ввода! Введите число");
                    }
                }
                balanceTek -= sum;
                balanceSb += sum;
            }
            else
            {

                Console.WriteLine("Введите сумму ");

                while (balanceSb - sum < 0)
                {
                    Console.WriteLine("Ошибка ввода! Введите число");
                    if (!decimal.TryParse(Console.ReadLine(), out sum))
                    {

                    }
                }
                balanceTek += sum;
                balanceSb -= sum;
            }

        }









    }






                
            
        
    
}

