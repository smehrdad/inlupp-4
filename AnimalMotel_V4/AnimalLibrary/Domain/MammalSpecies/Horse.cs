//Ali Sabbagh zadeh 7307063458
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalMotel
{
    public class Horse : Mammal
    {
        public Horse()
        {
        }
        public override string AnimalSpecificData()
        {
            return GetAnimalSpecificData;
        }
    }
}
