//Ali Sabbagh zadeh 7307063458
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalMotel;

namespace AnimalMotel
{
    public class BirdFactory
    {
        public  Animal Createbird(BirdSpecies birdSpecies)
        {

            Bird animalObj = null;

            switch (birdSpecies)
            {
                case BirdSpecies.Dove:
                    animalObj = new Dove();
                    break;
                case BirdSpecies.Eagle:
                    animalObj = new Eagle();
                    break;

                case BirdSpecies.Pelican:
                    animalObj = new Pelican();
                    break;
               
                default:
                    Debug.Assert(false, "To be completed!");
                    break;
            }


            animalObj.CategoryType = CategoryType.Bird;

            return animalObj;     //return the created animal object.
        }
    }
}
