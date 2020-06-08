using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ5
{
    /// <summary>
    /// ConcreteComponent1
    /// </summary>
    class BigHamburger :Hamburger
    {
        public BigHamburger() : base("Большой бургер") { }
        public override int GetPrice()
        {
            return 200;
        }
    }
}
