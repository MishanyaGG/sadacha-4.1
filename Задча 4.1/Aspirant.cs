using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задча_4._1
{
    class Aspirant : All
    {
        /// <summary>
        /// Руководитель
        /// </summary>
        public string teacher;
        /// <summary>
        /// Код специальности
        /// </summary>
        public int kod_spec;
        public Aspirant(string name, int facultet, int god_post, string teacher, int kod_spec) : base(name, facultet, god_post)
        {
            this.teacher = teacher;
            this.kod_spec = kod_spec;
        }
        new public void show()
        {
            string x_f = "";
            string x_s = "";
            string[] fac = new string[3];
            fac[0] = "Хмимия";
            fac[1] = "Экономический";
            fac[2] = "Информационные технологии";

            string[] info_him = new string[2];
            info_him[0] = "02.00.01 Неорганическая химия";
            info_him[1] = "02.00.04 Физическая химия";

            string[] info_ek = new string[3];
            info_ek[0] = "38.03.02 Менеджмент";
            info_ek[1] = "42.03.01 Реклама и связи с общественностью";
            info_ek[2] = "38.03.01 Экономика";

            string[] info_it = new string[3];
            info_it[0] = "09.03.02 Информационные системы и технологии";
            info_it[1] = "09.06.01 Информатика и вычислительная техника";
            info_it[2] = "05.13.11 Математическое и программное обеспечение вычислительных машин, комплексов и компьютерных сетей";

            if (facultet == 1)
            {
                x_f = fac[0];
                if (kod_spec == 1) x_s = info_him[0];
                else x_s = info_him[1];
            }
            if (facultet == 2)
            {
                if (kod_spec == 1) x_s = info_ek[0];
                if (kod_spec == 2) x_s = info_ek[1];
                else x_s = info_ek[2];
            }
            if (facultet == 3)
            {
                x_f = fac[2];
                if (kod_spec == 1) x_s = info_it[0];
                if (kod_spec == 2) x_s = info_it[1];
                if (kod_spec == 3) x_s = info_it[2];
            }
            base.show();
            Console.WriteLine($"Руководитель аспиранта {teacher}\nФакультет {x_f}\nКод специальности {x_s}\n");
        }
    }
    //TODO Аспиранты
}
