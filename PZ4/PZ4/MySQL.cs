using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ4
{
    /// <summary>
    /// Класс для MySQL
    /// </summary>
    class MySQL :Database
    {
        public void createDataBase()
        {
            Console.WriteLine("[MySQL] Создать Базу данных");
        }
        public void createTable()
        {
            Console.WriteLine("[MySQL] Создать Таблицу");
        }
        public void dropTable()
        {
            Console.WriteLine("[MySQL] Удалить Таблицу");
        }
        public void alterTable()
        {
            Console.WriteLine("[MySQL] Изменить Таблицу");
        }
        public void createTrigger()
        {
            Console.WriteLine("[MySQL] Создать Триггер");
        }
        public void alterTrigger()
        {
            Console.WriteLine("[MySQL] Изменить Триггер");
        }
        public void dropTrigger()
        {
            Console.WriteLine("[MySQL] Удалить Триггер");
        }
        public void createView()
        {
            Console.WriteLine("[MySQL] Создать Представление");
        }
        public void alterView()
        {
            Console.WriteLine("[MySQL] Изменить Представление");
        }
        public void dropView()
        {
            Console.WriteLine("[MySQL] Удалить Представление");
        }
    }
}
