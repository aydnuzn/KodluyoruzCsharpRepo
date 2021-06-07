using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw26_Interface.Car
{
    public class Civic : ICar
    {
        public CarBrand Brand()
        {
            return CarBrand.Honda;
        }

        public Color StandardColor()
        {
            return Color.Gray;
        }

        public int WheelsNumber()
        {
            return 4;
        }
    }
}
