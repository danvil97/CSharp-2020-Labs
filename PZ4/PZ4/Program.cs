using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите СУБД для работы (Oracle, MySQL, PostgreSQL)");
            string dbID = Console.ReadLine();
            Database userDatabase;
            try
            {
                switch (dbID.ToLower())
                {
                    case "oracle":
                        userDatabase = new Oracle();
                        break;
                    case "mysql":
                        userDatabase = new MySQL();
                        break;
                    case "postgresql":
                        userDatabase = new PostgreSQL();
                        break;
                    case "":
                        throw new ArgumentException("Ошибка! Пустая строка");
                    default:
                        throw new ArgumentException("Ошибка! Базы данных не существует");
                }
            
            Console.WriteLine("Введите нмоера операций, которые необходимо произвести. Вводить через запятую");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(">1  - Создать БД\n>2  - Создать таблицу\n>3  - Удалить таблицу\n>4  - Изменить таблицу\n>5  - Создать триггер\n>6  - Изменить триггер\n>7  - Удалить триггер\n>8  - Создать представление\n>9  - Изменить представление\n>10 - Удалить представление");
            Console.ResetColor();
            string dbActions = Console.ReadLine();
                if (dbActions.Length < 1)
                {
                    throw new ArgumentException("Ошибка! Пустая строка");
                }
            string[] dbActionsArr = dbActions.Split(',');
            User user1 = new User(userDatabase);
            foreach(string action in dbActionsArr)
            {
                    if (int.Parse(action) > 10 || int.Parse(action) < 1)
                        throw new ArgumentException($"Ошибка! Данной команды ({int.Parse(action)}) не существует!");
                user1.getAction(int.Parse(action));
            }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
        }
    }
}
