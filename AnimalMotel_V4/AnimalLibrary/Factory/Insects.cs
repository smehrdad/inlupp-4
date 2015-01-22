//Ali Sabbagh zadeh 7307063458
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalMotel
{
   public abstract class Insect : Animal
    { 
	    //Is the insect poisonous
	    private bool m_ispoisonous;
        string getAnimalSpecificData;
	   
        /// <summary>
	    /// Default constructor
	    /// </summary>
	    public Insect()
	    {
	    }

	    //property related to m_ispoisonous
	    public bool IsPoisonous 
        {
		    get { return m_ispoisonous; }
		    set { m_ispoisonous = value; }
	    }

        public new string GetAnimalSpecificData
        {
            get { return getAnimalSpecificData; }
            set { getAnimalSpecificData = value; }
        }
	    //A VG (ECT A and B) part
	    //An abstract method for insect sub classes
	    /// <summary>
	    /// For ll insects objects, info on their invasiveness and stinkynss
	    /// should be provided
	    /// </summary>
	    public abstract string SetStinkAndInvasiveData();

    }

}
