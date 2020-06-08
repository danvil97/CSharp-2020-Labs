using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ4
{
    /// <summary>
    /// Класс для Oracle
    /// </summary>
    class Oracle :Database
    {
        public void createDataBase()
        {
            Console.WriteLine("[Oracle] Создать Базу данных");
        }
        public void createTable() {
            Console.WriteLine("[Oracle] Создать Таблицу");
        }
        public void dropTable() {
            Console.WriteLine("[Oracle] Удалить Таблицу");
        }
        public void alterTable() {
            Console.WriteLine("[Oracle] Изменить Таблицу");
        }
        public void createTrigger() {
            Console.WriteLine("[Oracle] Создать Триггер");
        }
        public void alterTrigger() {
            Console.WriteLine("[Oracle] Изменить Триггер");
        }
        public void dropTrigger() {
            Console.WriteLine("[Oracle] Удалить Триггер");
        }
        public void createView() {
            Console.WriteLine("[Oracle] Создать Представление");
        }
        public void alterView() {
            Console.WriteLine("[Oracle] Изменить Представление");
        }
        public void dropView() {
            Console.WriteLine("[Oracle] Удалить Представление");
        }

    }
}
