//Ali Sabbagh zadeh 7307063458
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalMotel
{
   public class ReptileFactory
    {
        public Animal CreateReptile(ReptileSpecies reptileSpecies)
        {

            Reptile animalObj = null;

            switch (reptileSpecies)
            {
                case ReptileSpecies.Frog:
                    animalObj = new Frog();
                    break;
                case ReptileSpecies.Lizard:
                    animalObj = new Lizard();
                    break;

                case ReptileSpecies.Snake:
                    animalObj = new Snake();
                    break;

                default:
                    Debug.Assert(false, "To be completed!");
                    break;
            }


            animalObj.CategoryType = CategoryType.Reptile;

            return animalObj;     //return the created animal object.
        }
    }
}
