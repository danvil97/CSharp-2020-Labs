using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ5
{
    /// <summary>
    /// ConcreteComponent2
    /// </summary>
    class SmallHamburger : Hamburger
    {
        public SmallHamburger() : base("Маленький бургер") { }
        public override int GetPrice()
        {
            return 100;
        }
    }
}
