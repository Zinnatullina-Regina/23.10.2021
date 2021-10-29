using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vassal_moego_vassala_ne_moi_vassal
{
    class Program
    {



        static void Main(string[] args)
        {
            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Boris", "all", 7, "no"));


            workers.Add(new Worker("Ilxam", "it", 6, "no"));
            workers.Add(new Worker("Orkadi", "it", 5, "no"));
            workers.Add(new Worker("Vladimir", "it", 4, "no"));


            workers.Add(new Worker("Ilhat", "sistem", 3, "no"));
            workers.Add(new Worker("Ivan", "sistem", 2, "no"));
            workers.Add(new Worker("Ilia", "sistem", 1, "no"));
            workers.Add(new Worker("Vitia", "sistem", 1, "no"));
            workers.Add(new Worker("Evgeni", "sistem", 1, "no"));



            workers.Add(new Worker("Sergei", "razrab", 3, "no"));
            workers.Add(new Worker("Leisian", "razrab", 2, "no"));
            workers.Add(new Worker("Ildar", "razrab", 1, "no"));
            workers.Add(new Worker("Marat", "razrab", 1, "no"));
            workers.Add(new Worker("Dina", "razrab", 1, "no"));
            workers.Add(new Worker("Anton", "razrab", 1, "no"));





            Console.WriteLine("Введите кол-во задач");
            int colvo;
            while ((!int.TryParse(Console.ReadLine(), out colvo) || colvo < 0))
            {
                Console.WriteLine("Ошибка ввода! Введите число");
            }
            Console.WriteLine("Введите Ваше имя ");
            string iam = Console.ReadLine();

            List<Task> Tasks = new List<Task>();
            
            for (int i = 0; i < colvo; i++)
            {
                Console.WriteLine("Введите задание ");
                string nametask = Console.ReadLine();
                Console.WriteLine("Введите отдел");
                string otdel = Console.ReadLine();
                Console.WriteLine("Введите уровень сложности");
                int kriteri;
                
                while ((!int.TryParse(Console.ReadLine(), out kriteri) || kriteri < 0 || kriteri > 7))
                {
                    Console.WriteLine("Ошибка ввода! Введите число");
                }
                Console.WriteLine("Введите кому адресовано задание");
                string  komy= Console.ReadLine();
               
                
                Tasks.Add(new Task(nametask, komy, otdel, kriteri ));
            }








            for (int i = 0; i < colvo; i++)
            {
                Console.WriteLine($"Задача {Tasks[i].NameTask}");
                int w = 0;
                while (!((iam).Equals(workers[w].Name))) 
                {
                    w++;
                }
                int o = 0;
                while (!((Tasks[i].Name).Equals(workers[o].Name)))
                {
                    o++;
                }
               

                if (workers[w].Statu - 1 == workers[o].Statu )
                {
                    for (int r = 0; r < workers.Count; r++)
                    {
                        if ((Tasks[i].Name).Equals(workers[r].Name))
                        {
                            int temp = r;
                            while (!((Tasks[i].Otdels).Equals(workers[temp].Specialist)))
                            {

                                temp++;

                            }

                            Console.WriteLine($"From {workers[w].Name} to {workers[temp].Name} ");

                            while (workers[temp].Statu > Tasks[i].StatuTasks)
                            {
                                temp++;
                                Console.WriteLine($"From {workers[temp-1].Name} to {workers[temp].Name} ");

                            }

                            bool anila = true;
                            int remil = temp;
                            while (anila)
                            {
                                if (remil + 1 <= workers.Count && (workers[remil].Specialist).Equals(workers[remil + 1].Specialist))
                                {
                                    if ((workers[remil].Havingtask).Equals("no"))
                                    {
                                        workers[remil].Havingtask = Tasks[i].NameTask;
                                        anila = false;
                                    }
                                    else
                                    {
                                        temp++;

                                        Console.WriteLine($"From {workers[temp].Name} to {workers[remil].Name} ");
                                    }
                                }

                                else
                                {
                                    while (!((workers[temp].Havingtask).Equals("no")))
                                    {
                                        temp--;
                                    }

                                    workers[temp].Havingtask = Tasks[i].NameTask;
                                    anila = false;
                                    Console.WriteLine($"From {workers[temp + 1].Name} to {workers[temp].Name} ");

                                }

                            }

                        }

                    }

                }
                else
                {
                    Console.WriteLine("Вассал моего вассала - не мой вассал");

                }

            }

             







                Console.ReadKey();
        }
    }
}
