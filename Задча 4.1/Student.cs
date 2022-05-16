using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задча_4._1
{
    class Student : All
    {
        /// <summary>
        /// Рейтинг
        /// </summary>
        public double rang;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="facultet">Факультет</param>
        /// <param name="god_post">Год поступления</param>
        /// <param name="rang">Рейтинг</param>
        public Student(string name, int facultet, int god_post, double rang) : base(name, facultet, god_post)
        {
            this.rang = rang;
        }
        new public void show()
        {
            string x_f = ""; 
            string[] fac = new string[3];
            fac[0] = "Хмимия";
            fac[1] = "Экономический";
            fac[2] = "Информационные технологии";

            if (facultet == 1) x_f = fac[0];
            if (facultet == 2) x_f = fac[1];
            else x_f = fac[2];
            base.show();
            Console.WriteLine($"Факультет {x_f}\nРейтинг студента {rang}\n");
        }
    }
    //TODO Студенты
}
