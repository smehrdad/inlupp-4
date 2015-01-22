//Ali Sabbagh zadeh 7307063458

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//TODO:
//using Assignment1CS.Categories;

namespace AnimalMotel
{

    /// <summary>
    /// This class inherits the Insect class, and then it defines
    /// properties and methods that are particular to the Butterfly species
    /// </summary>
    public class Butterfly : Insect
    {
        private bool m_larvalPhase;

        /// <summary>
        /// Constructor - Create an instance of an Insect
        /// </summary>
        public Butterfly()
        {
        }

        /// <summary>
        /// Implementation of the abstract method in the base class
        /// </summary>
        /// <returns>A string containing specific info about the Butterfly</returns>
        /// <remarks></remarks>
        public override string AnimalSpecificData()
        {
            //TODO:
            //dynamic strInfo = ExtraAnimalInfo;
            //string strout = (string.IsNullOrEmpty(strInfo) ? string.Empty : strInfo);

            //string strLarval = " not ";
            //if (m_larvalPhase)
            //{
            //    strLarval = "";
            //}

            //strout += string.Format("This butterfly is  {0} In the larval phase.", strLarval);
            //strout += Environment.NewLine + SetStinkAndInvasiveData();
            //return strout;
            GetAnimalSpecificData = "";
            return null;
        }

        //A VG (ECT A and B) part
        /// <summary>
        /// Implementation of abstract method defined in base class
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public override string SetStinkAndInvasiveData()
        {
            string strOut = "Butterflies are beautiful.  They do not stink or get aggressive!";
            return strOut;
        }


        /// <summary>
        ///  Animals with indirect development such as insects, amphibians, or cnidarians 
        /// typically have a larval phase of their life cycle.
        /// </summary>
        /// <returns>True if the animal is in teh larval phase.</returns>
        /// <remarks>property related to m_larvalPhase.</remarks>
        public bool LarvalPhase
        {
            get { return this.m_larvalPhase; }
            set { this.m_larvalPhase = value; }
        }

    }

}
