﻿//Ali Sabbagh zadeh 7307063458
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalMotel
{
    public class Goldfish : Marine
    {
        public Goldfish()
        {

        }
        public override string AnimalSpecificData()
        {
            return GetAnimalSpecificData;
        }

    }
}
