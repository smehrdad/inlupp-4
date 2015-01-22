//Ali Sabbagh zadeh 7307063458
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalMotel
{
    public interface IAnimal
    {
        double Age { get; set; }
        CategoryType CategoryType { get; set; }
        GenderType GenderType { get; set; }
        int ID { get; set; }
        string GetAnimalSpecificData { get; set; }
        string AnimalSpecificData();
    }
}

