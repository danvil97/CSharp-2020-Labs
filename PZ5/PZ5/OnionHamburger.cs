using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ5
{
    /// <summary>
    /// ConcreteDecorator2
    /// </summary>
    class OnionHamburger : HamburgerDecorator
    {
        public OnionHamburger(Hamburger h) : base(h.Name + ", с луком", h) { }
        public override int GetPrice()
        {
            return hamburger.GetPrice() + 53;
        }
    }
}
