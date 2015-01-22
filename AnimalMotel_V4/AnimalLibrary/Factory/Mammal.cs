//Ali Sabbagh zadeh 7307063458
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalMotel
{
    public class Mammal : Animal
    {
        //[Serializable]
        private int nmberOFTeeth;
        private bool animalIsUnderQuarantine;
        private int dagInQuantine;

        public int NumberOFTeeth
        {
            get { return this.nmberOFTeeth; }
            set { this.nmberOFTeeth = value; }
        }

        public bool AnimalIsUnderQuarantine
        {
            get { return animalIsUnderQuarantine; }
            set { this.animalIsUnderQuarantine = value; }
        }

        public int DagInQuantine
        {
            get { return this.dagInQuantine; }
            set { this.dagInQuantine = value; }
        }
    }
}
