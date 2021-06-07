using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw26_Interface.Car
{
    public class Corolla : ICar
    {
        public CarBrand Brand()
        {
            return CarBrand.Toyota;
        }

        public Color StandardColor()
        {
            return Color.White;
        }

        public int WheelsNumber()
        {
            return 4;
        }
    }
}
