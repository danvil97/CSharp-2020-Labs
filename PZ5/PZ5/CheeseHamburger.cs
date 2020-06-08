using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ5
{
    /// <summary>
    /// ConcreteDecorator1
    /// </summary>
    class CheeseHamburger :HamburgerDecorator
    {
        public CheeseHamburger(Hamburger h) : base(h.Name + ", с сыром", h) { }
        public override int GetPrice()
        {
            return hamburger.GetPrice() + 25;
        }
    }
}
