using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задча_4._1
{
    class All
    {
        /// <summary>
        /// Имя
        /// </summary>
        protected string name;
        /// <summary>
        /// Год поступления
        /// </summary>
        protected int god_post;
        /// <summary>
        /// Факультет
        /// </summary>
        protected int facultet;
        
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="facultet">Факультет</param>
        /// <param name="god_post">Год поступления</param>
        protected All (string name,int facultet,  int god_post)
        {
            this.name = name;
            this.facultet = facultet;
            this.god_post = god_post;
        }
        public void show()
        {
            Console.WriteLine($"Имя {name}\nГод поступления {god_post}");
        }
    }
    //TODO Всё
}
