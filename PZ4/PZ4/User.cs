using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ4
{
    /// <summary>
    /// Класс User, зависит от Database
    /// </summary>
    class User
    {
        Database DataBase;
        public User(Database db)
        {
            DataBase = db;
        }
        public void getAction(int actionID)
        {
            try { 
            switch (actionID)
            {
                case 1:
                    DataBase.createDataBase();
                    break;
                case 2:
                    DataBase.createTable();
                    break;
                case 3:
                    DataBase.dropTable();
                    break;
                case 4:
                    DataBase.alterTable();
                    break;
                case 5:
                    DataBase.createTrigger();
                    break;
                case 6:
                    DataBase.alterTrigger();
                    break;
                case 7:
                    DataBase.dropTrigger();
                    break;
                case 8:
                    DataBase.createView();
                    break;
                case 9:
                    DataBase.alterView();
                    break;
                case 10:
                    DataBase.dropView();
                    break;
                
            }
            }
            catch(Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor(); 
                return;
            }
        }
    }
}
