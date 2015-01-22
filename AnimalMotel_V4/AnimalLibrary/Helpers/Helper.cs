using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalMotel
{
    public class Helper
    {
        public bool CheckDouble(string value, out double newValue)
        {
            bool valueIsDouble = false;
            if (Double.TryParse(value, out newValue))
                return valueIsDouble = true;
            else return valueIsDouble;

        }

        public bool CheckInteger(string value, out int newValue)
        {
            bool valueIsDouble = false;
            if (int.TryParse(value, out newValue))
                return valueIsDouble = true;
            else return valueIsDouble;

        }

    }
}
