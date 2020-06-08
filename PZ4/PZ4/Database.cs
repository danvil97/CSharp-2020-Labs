using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ4
{
    /// <summary>
    /// Все возможные операции
    /// </summary>
    interface Database
    {
        void createDataBase();
        void createTable();
        void dropTable();
        void alterTable();
        void createTrigger();
        void alterTrigger();
        void dropTrigger();
        void createView();
        void alterView();
        void dropView();

    }
}
