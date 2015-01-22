//Ali Sabbagh zadeh 7307063458
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalMotel
{
    public class MarineFactory
    {
        public Animal CreateMarine(MarineSpecies marineSpecies)
        {

            Marine animalObj = null;

            switch (marineSpecies)
            {
                case MarineSpecies.Goldfish:
                    animalObj = new Goldfish();
                    break;
                case MarineSpecies.Whales:
                    animalObj = new Whales();
                    break;

       
                default:
                    Debug.Assert(false, "To be completed!");
                    break;
            }


            animalObj.CategoryType = CategoryType.Marine;

            return animalObj;     //return the created animal object.
        }
    }
}
