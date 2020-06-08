using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ4
{
    /// <summary>
    /// Класс для PostgreSQL
    /// </summary>
    class PostgreSQL :Database
    {
        public void createDataBase()
        {
            Console.WriteLine("[PostgreSQL] Создать Базу данных");
        }
        public void createTable()
        {
            Console.WriteLine("[PostgreSQL] Создать Таблицу");
        }
        public void dropTable()
        {
            Console.WriteLine("[PostgreSQL] Удалить Таблицу");
        }
        public void alterTable()
        {
            Console.WriteLine("[PostgreSQL] Изменить Таблицу");
        }
        public void createTrigger()
        {
            Console.WriteLine("[PostgreSQL] Создать Триггер");
        }
        public void alterTrigger()
        {
            Console.WriteLine("[PostgreSQL] Изменить Триггер");
        }
        public void dropTrigger()
        {
            Console.WriteLine("[PostgreSQL] Удалить Триггер");
        }
        public void createView()
        {
            Console.WriteLine("[PostgreSQL] Создать Представление");
        }
        public void alterView()
        {
            Console.WriteLine("[PostgreSQL] Изменить Представление");
        }
        public void dropView()
        {
            Console.WriteLine("[PostgreSQL] Удалить Представление");
        }
    }
}
