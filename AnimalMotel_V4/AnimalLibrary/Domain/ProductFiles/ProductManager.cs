//ProductManager.cs

//Created:  Farid Naisan 2007-05-19
//Revised:  Farid Naisan 2012-12-05  ArrayList changed to List
//This class is declared as partial as it is made of several files


using System;
using System.Collections;
using System.Collections.Generic;  // for List<T>
//using ProductRegistryCS.Files;
using System.Diagnostics;

namespace AnimalMotel
{
    [Serializable]
    public partial class ProductManager
    {
        private List<Mammal> m_productRegistry;

        //Constructor

        public ProductManager()
        {
            m_productRegistry = new List<Mammal>();
        }

        /// <summary>
        /// Returns  a copy of an element at the position = index
        /// The copy constructor of the Product class is called to return 
        /// a copy of the object.  In this case, any changes to the copy
        /// will not affect the object in the m_productRegistry
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        /// <remarks>return m_productRegistry[index] returns the reference of the element.
        /// returning a copy is safer</remarks>
        public Mammal GetProduct(int index)
        {
            //return m_productRegistry[index];  //not safe any changes to the object will affect the reg.
            //TODO:
           // Mammal copyObj = new Mammal(m_productRegistry[index]);  //copying is done in the Product class
            //return copyObj;
            return null;
        }

        //Property for the number
        public int Count
        {
            get { return m_productRegistry.Count; }
        }

        //Info about an object from the list
        public string GetInfoString(int index)
        {
            return GetProduct(index).ToString();
        }

        //Add a new object to the list
        public int AddProduct(string name, double price, int number)
        {
            Debug.Assert((name != null), "Kill the programmer!");
            //TODO:
            //Mammal product = new Mammal(name, price, number);
            //product.ID = SetNewID();
            //m_productRegistry.Add(product);
            return m_productRegistry.Count - 1;
        }

        //Add a new object to the list - overloaded function
        public int AddProduct(Mammal prod)
        {
            if (prod != null)
            {
               //TODO: prod.ID = SetNewID();
                m_productRegistry.Add(prod);
            }
            return m_productRegistry.Count - 1;
        }
        private string SetNewID()
        {
            const string startID = "PR";
            return startID + Count.ToString();
        }
        //Change the values of the object at the position=index in the list
        public bool ChangeProduct(Mammal prod, int index)
        {
            bool ok = false;
            if ((prod != null) && CheckIndex(index))
            {
                m_productRegistry[index] = prod;
                ok = true;
            }
            return ok;
        }

        //Remove the object at position= index from the list
        public bool DeleteProduct(int index)
        {
            bool ok = false;
            if (CheckIndex(index))
            {
                m_productRegistry.RemoveAt(index);
                ok = true;
            }

            return ok;
        }


        public bool CheckIndex(int index)
        {
            return (index >= 0) && (index < m_productRegistry.Count);

        }
        //Return the sum of the price of all the products
        public double TotalSum
        {
            get
            {
                double sum = 0.0;
                for (int i = 0; i < Count; i++)
                {
                    //TODO:
                    //sum += ((Mammal)m_productRegistry[i]).TotalValue;
                }

                return sum;
            }
        }
        //Save and read data files
        public bool SaveDataToFile(string fileName, FileTypes fileExt, out string errorMsg)
        {
            bool ok = true;
            errorMsg = string.Empty;

            switch (fileExt)
            {
                case FileTypes.txt:
                    ok = WriteToTextFile(fileName, out errorMsg);
                    break;
                    //TODO:
                //case FileTypes.xml:
                //    ok = WriteToXMLFile(fileName, out errorMsg);
                //    break;
                //case FileTypes.dat:
                //    ok = SerializeDataToFile(fileName, out errorMsg);
                //    break;
                //default:
                //    errorMsg = "Unknown file type!";
                //    ok = false;
                //    break;
            }
            return ok;
        }

        //Save and read data files
        public bool ReadDataFromFile(string fileName, FileTypes fileExt, out string errorMsg)
        {
            bool ok = true;
            errorMsg = string.Empty;

            switch (fileExt)
            {
                case FileTypes.txt:
                    ok = ReadFromTextFile(fileName, out errorMsg);
                    break;
                //case FileTypes.xml:
                //    ok = ReadXMLFile(fileName, out errorMsg);
                //    break;
                //case FileTypes.dat:
                //    ok = DeserializeDataFromFile(fileName, out errorMsg);
                //    break;
                //default:
                //    errorMsg = "Unknown file type!";
                //    ok = false;
                //    break;
            }
            return ok;
        }

    }//class
}
