//Code example
//Created: sometimes ago
//Revised:2012-07-07 by Farid Naisan
//
//To do: Review and investigate the code and make your comments 
//of what you believe the class and its methods do.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.ComponentModel;

namespace DataBindingProducts.ProductFiles
{
    class Product
    {
        private string name;    //name of a product != empty
        private double price;   //price, >= 0.0
        private int count;      //Quantity of this product >=0
        private DateTime date;  //Date of registration

        private BindingList<Producer> m_producers = new BindingList<Producer>();
        public Product() { }  //default constructor, needed when Product is a member in another class

        //Construct with parameters
        public Product(string name, double price, int number)
        {
            this.name = name;
            this.price = price;
            this.count = number;
            this.date = DateTime.Now;
        }

        //Copy Constructor - clone the other product
        //this poroduct is created with the same values from another Product object
        public Product(Product other)
        {
            this.name = other.name;
            this.price = other.price;
            this.count = other.count;
            this.date = other.date;
        }

        //Submit only a clone copy, not the object ref, to protect
        //the object from changes.
        public Product Clone()
        {
            return new Product(this.name, this.price, this.count);
        }


        //Get and set properties used for binding
        //---------------------------------------------------
        public string Name
        {
            get { return name; }
            set
            {
                if (value != String.Empty)
                    name = value;
            }
        }
        public int Count
        {
            get { return count; }
            set
            {
                if (value >= 0)
                    count = value;
            }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (value >= 0.0)
                {
                    price = value;
                }
            }
        }

        //returns price times the number
        public double Sum
        {
            get { return Math.Round(price * count, 2); }
        }

        //returns the govermental tax (VAT)
        public double Tax
        {
            get
            {
                const double taxFactor = 1.11;
                return Math.Round(price / taxFactor, 2);
            }
        }

        public BindingList<Producer> Producers
        {
            get
            {
                System.Diagnostics.Debug.Assert(m_producers != null);
                //should have returned a clone copy of the list
                return m_producers;
            }
            set { m_producers = value; }
        }

        public bool CheckData()
        {
            return ((!name.Equals(String.Empty)) && (price >= 0.0) && (count >= 0));
        }

        public override string ToString()
        {

            return String.Format("{0,9} {1,-15} {2,8} {3, 8:f2}  {4,12:f2}", date.ToShortDateString(), name, count, price, Sum);

        }

    }
}
