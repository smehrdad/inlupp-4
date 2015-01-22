//Ali Sabbagh zadeh 7307063458
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace AnimalMotel
{

    public class MammalFactory
    {

        public Animal CreateMammal(MammalSpecies mammalSpecies, int daysOfQuarantine, bool underQuarantine, int numberOfteeth)
        {

            Mammal animalObj = null;

            switch (mammalSpecies)
            {
                case MammalSpecies.Bear:
                    animalObj = new Bear();
                    break;
                case MammalSpecies.Cat:
                    animalObj = new Cat();
                    break;

                case MammalSpecies.Deer:
                    animalObj = new Deer();
                    break;
                case MammalSpecies.Lion:
                    animalObj = new Lion();
                    break;
                case MammalSpecies.Dog:
                    animalObj = new Dog();
                    break;
                case MammalSpecies.Horse:
                    animalObj = new Horse();
                    break;
                case MammalSpecies.Panda:
                    animalObj = new Panda();
                    break;
                case MammalSpecies.Wolf:
                    animalObj = new Wolf();
                    break;

                default:
                    Debug.Assert(false, "To be completed!");
                    break;
            }


            animalObj.CategoryType = CategoryType.Mammal;
            animalObj = AddNewSpecifications(animalObj, daysOfQuarantine, underQuarantine, numberOfteeth);

            return animalObj;     //return the created animal object.
        }



        private Mammal AddNewSpecifications(Mammal animalObj, int daysOfQuarantine, bool underQuarantine, int numberOfteeth)
        {
            animalObj.DagInQuantine = daysOfQuarantine;
            animalObj.AnimalIsUnderQuarantine = underQuarantine;
            animalObj.NumberOFTeeth = numberOfteeth;
            StringBuilder builder = new StringBuilder();
            if (underQuarantine)
            {
                animalObj.GetAnimalSpecificData += String.Format(" To be quarantine in {0} day(s) \r\n", animalObj.DagInQuantine);                
            }
            animalObj.GetAnimalSpecificData += String.Format("The animals has {0} teeth.\r\n", animalObj.NumberOFTeeth);
            return animalObj;
        }

    }

}
