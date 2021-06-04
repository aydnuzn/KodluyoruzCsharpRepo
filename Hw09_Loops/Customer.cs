using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw09_Loops
{
    class Customer
    {
        private string _IdentityNumber;

        public string IdentityNumber
        {
            get { return _IdentityNumber; }
            set
            {
                if (value.Length == 11 && IdentityControl(value))
                    this._IdentityNumber = value;
                else if (value.Equals("0"))
                    this._IdentityNumber = value;
                else
                    Console.WriteLine("Enter only numbers and 11 digits");
            }
        }

        private bool IdentityControl(string tcNo)
        {
            foreach (char number in tcNo)
                if (!Char.IsNumber(number))
                    return false;
            return true;
        }
    }
}
