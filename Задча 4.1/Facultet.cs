using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задча_4._1
{
    class Facultet
    {
        public int facultet;
        
        /// <summary>
        /// Информация о факультетах
        /// </summary>
        public void info_facutelt()
        {
            Console.WriteLine("Факультеты:\n1) Химия\n2) Экономический\n3) Информационные технологии");
        }
        /// <summary>
        /// Информация о специальностях факултета Химия
        /// </summary>
        public void info_facultet_him()
        {
            Console.WriteLine("Специальности Химия:\n1) 02.00.01 Неорганическая химия\n2) 02.00.04 Физическая химия");
        }
        /// <summary>
        /// Информация о специальностях факултета Экономика
        /// </summary>
        public void info_facultet_ek()
        {
            Console.WriteLine("Специальности Экономический:\n1) 38.03.02 Менеджмент\n2) 42.03.01 Реклама и связи с общественностью\n3) 38.03.01 Экономика");
        }
        /// <summary>
        /// Информация о специальностях факультета ИТ
        /// </summary>
        public void info_facultet_it()
        {
            Console.WriteLine("Специальности Информационные технологии:\n1) 09.03.02 Интемы иформационные сис технологии\n2) 09.06.01 Информатика и вычислительная техника\n3) 05.13.11 Математическое и программное обеспечение вычислительных машин, комплексов и компьютерных сетей");
        }
       
    }
    //TODO Факультеты
}
