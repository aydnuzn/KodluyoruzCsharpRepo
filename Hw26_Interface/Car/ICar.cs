using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw26_Interface
{
    public interface ICar
    {
        int WheelsNumber();
        CarBrand Brand();
        Color StandardColor();
    }
}
