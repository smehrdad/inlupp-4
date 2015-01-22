//Ali Sabbagh zadeh 7307063458


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Diagnostics;

namespace AnimalMotel
{
    public class InsectFactory
    {

        public  Insect CreateInsect(InsectSpecies Species)
        {

            Insect animalObj = null;
            switch (Species)
            {
                case InsectSpecies.Bee:
                    animalObj = new Bee();          
                    break;
                //Continue with the rest
                case InsectSpecies.Butterfly:
                    animalObj = new Butterfly();   
                    break;
                case InsectSpecies.Fly:
                    animalObj = new Fly();
                     break;

                default:
                    Debug.Assert(false, "To be completed!");
                    break;
            }

            
            animalObj.CategoryType = CategoryType.Insect;

            return animalObj;  
        }

    }

}
