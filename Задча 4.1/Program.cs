using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задча_4._1
{
    //TODO Описать иерархию классов «Студенты/Аспиранты». Характеристики студента: имя, факультет, год поступления, рейтинг. Характеристики аспиранта: имя, факультет, год поступления, руководитель, код специальности. Методы классов разработать самостоятельно. 1.Создать массив объектов класса «Студент». 2.Создать массив объектов класса «Аспирант». 3.Получить полную информацию о трех студентах первого курса экономического факультета с самым высоким рейтингом. 4.Выяснить, кто из аспирантов специальности 05.13.11 завершает обучение в текущем году. 5.Получить полную информацию обо всех студентах и аспирантах
    class Program
    {
        static void Main(string[] args)
        {
            string name, ruc;
            int god_post, facultet_stud, kod_spec, tec_god, i, facultet_asp;
            float rang;
            tec_god = 2022;
            facultet_stud = 0;
            kod_spec = 0;
            god_post = 0;
            i = 0;
            facultet_asp = 0;
            Console.WriteLine("Количество студентов");
            int count_stud = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Количество аспирантов");
            int count_asp = Convert.ToInt32(Console.ReadLine());
            Student[] stud = new Student[count_stud];
            Aspirant[] asp = new Aspirant[count_asp];
            string[] asp_2022 = new string[count_asp];
            Student[] maxrang = new Student[count_stud];
            Facultet fac = new Facultet();
            double max = double.MinValue;
            
            //Описание студентов
            for (int x = 0; x<count_stud; x++)
            {
                Console.Clear();
                Console.WriteLine("Введите имя студента");
                name = Console.ReadLine();
                Console.WriteLine("Выберите факультет. Введите цифру факультета");
                fac.info_facutelt();
                facultet_stud = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Год поступления {name}");
                god_post = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Рейтинг {name}, писать через запятую. Пятибальная система");
                rang = float.Parse(Console.ReadLine());
                Math.Round(rang, 0);
                stud[x] = new Student(name, facultet_stud, god_post, rang);
                if (stud[x].rang > max)
                {
                    max = stud[x].rang;
                    maxrang[x] = stud[x];
                }
            }
            
            for (int x = 0; x < count_asp; x++) //Описание аспирантов
            {
                Console.Clear();
                Console.WriteLine("Введите имя аспиранта");
                name = Console.ReadLine();
                Console.WriteLine("Выберите факультет. Введите цифру факультета");
                fac.info_facutelt();
                facultet_asp = Convert.ToInt32(Console.ReadLine());
                if (facultet_asp == 1)
                {
                    Console.WriteLine($"Код специальности {name}. Выберите цифру");
                    fac.info_facultet_him();
                    kod_spec = Convert.ToInt32(Console.ReadLine());
                }
                else if (facultet_asp == 2)
                {
                    Console.WriteLine($"Код специальности {name}. Выберите цифру");
                    fac.info_facultet_ek();
                    kod_spec = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine($"Код специальности {name}. Выберите цифру");
                    fac.info_facultet_it();
                    kod_spec = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine($"Год поступления {name}, текущий год - {tec_god}");
                god_post = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите руководителя");
                ruc = Console.ReadLine();
                asp[x] = new Aspirant(name, facultet_asp, god_post, ruc, kod_spec);
                if (kod_spec == 3)
                {
                    int god = tec_god - god_post;
                    if (god == 4) asp_2022[x] = name;
                    i++;
                }
            }
            Console.Clear();
            //Вывод информации о студентах
            Console.WriteLine("   Студенты\n");
            for (int x = 0; x < count_stud; x++)
            {
                stud[x].show();
            }
            //Вывод информации о аспирантах
            Console.WriteLine("   Аспиранты\n");
            for (int x = 0; x < count_asp; x++)
            {
                asp[x].show();
            }
            
            //if (facultet_stud == 2)
            //Аспиранты специанльности 05.13.11, которые заканчивают в этом году
            for (int x = 0; x==i; x++)
            {
                Console.WriteLine($"Аспиранты специанльности 05.13.11, которые заканчивают {tec_god}\n"+asp_2022[x]);
            }
            Console.WriteLine("Студенты с наивысшими рейтингами\n");
            for (int x = 0; x < count_stud; x++)
            {
                maxrang[x].show();
            }
        }
    }
}
