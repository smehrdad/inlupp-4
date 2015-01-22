//Ali Sabbagh zadeh 7307063458
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalMotel
{
    public class Animal : IAnimal
    {
        #region Variables

        private double age;
        private string name;
        private CategoryType categoryType;
        private GenderType genderType;
        private int id;
        string getAnimalSpecificData;

        #endregion

        #region IAnimal Members
        public virtual string AnimalSpecificData()
        {
            return GetAnimalSpecificData;
        }

        public virtual string GetAnimalSpecificData
        {
            get { return getAnimalSpecificData; }
            set { getAnimalSpecificData = value; }
        }

        public CategoryType CategoryType
        {
            get { return categoryType; }
            set { categoryType = value; }

        }

        public double Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public GenderType GenderType
        {
            get { return genderType; }
            set { genderType = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }


        #endregion
    }
}
