using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _8_lab
{

    
    



    class Program
    {

        public static string Reverse( ref string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            return new String(arr);
        }

        static void IfisIFormatTable(object obj)
        {
            if (obj is IFormattable)
            {
                Console.WriteLine(obj.ToString());
            }
            else
            {

                Console.WriteLine("Не удалось явно преобразовать к IFormatTable");
            }
        }




        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("\nВведите строку");
            string str = Console.ReadLine().ToLower();
            Console.WriteLine(Reverse( ref str));


            Console.WriteLine("\nЗадание 2");
            Console.WriteLine("\nВведите название");
            string what = Console.ReadLine();
            try
            {
                int count = 0;
                using (StreamReader reader = new StreamReader(what + ".txt"))
                {

                    while (reader.ReadLine() != null)
                    {
                        count++;


                    }
                    reader.Close();
                }






                using (StreamReader reader = new StreamReader( what + ".txt"))
                {
                    using (StreamWriter sw = new StreamWriter(@"Запись.txt"))
                    {
                        
                        int temp = 0;
                        while (temp < count )
                        { 
                            string stroki = reader.ReadLine().ToUpper();
                            sw.WriteLine(stroki);
                            temp++;
                        }
                    }
                        reader.Close();
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }




            Console.WriteLine("\nЗадание 3");
            Console.Write("Введите строку");
            object obj = Console.ReadLine();
            IfisIFormatTable(obj);
            






























            Console.ReadKey();
        }
    }
}
