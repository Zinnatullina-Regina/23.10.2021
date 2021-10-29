using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Homework
{

    



    class Program
    {
        public static void SearchMail(ref string s, int count)
        {
            string[] name = new string[count];
            string[] email = new string[count];

            int count0 = 0, count1 = 0;



            string[] stroki = s.ToLower().Split('#').ToArray();

            for (int i = 0; i < stroki.Length; i++)
            {

                switch (i)
                {
                    case 0:
                        name[count0] = stroki[i];
                        count0++;
                        break;
                    case 1:
                        using (StreamWriter sw = new StreamWriter(@"Зап.txt"))
                        {

                            email[count1] = stroki[i];
                            sw.WriteLine(email[count1].ToString());
                            count1++;
                            break;

                        }
                }

            }




        }




        static void Main(string[] args)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(@"mail.txt"))
            {

                while (reader.ReadLine() != null)
                {
                    count++;

                }
                reader.Close();
            }

            int temp = 0;
            using (StreamReader reader = new StreamReader(@"mail.txt"))
            {

                while (temp < count)
                {
                    string str = reader.ReadLine();
                    SearchMail(ref str, count);


                    temp++;
                }
            }




            Console.WriteLine(" 6");
            int countSongs = 4;
            List<Song> songs = new List<Song>();
            for (int i = 0; i < countSongs; i++)
            {
                Console.WriteLine("Введите название песни");
                string name = Console.ReadLine();
                Console.WriteLine("Введите название артиста");
                string author = Console.ReadLine();
                songs.Add(new Song(name, author));
               
            }
           



















            Console.ReadKey();

        }
    }
}
