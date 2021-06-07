using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw26_Interface.Car
{
    class Focus : ICar
    {
        public CarBrand Brand()
        {
            return CarBrand.Ford;
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
