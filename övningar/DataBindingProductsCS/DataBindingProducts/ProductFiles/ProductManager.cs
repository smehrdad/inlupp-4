using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace DataBindingProducts.ProductFiles
{
    class ProductManager
    {
        BindingList<Product> productReg = new BindingList<Product>();


        public ProductManager()
        {
            
        }
        public bool CheckIndex(int value)
        {
            return (value >= 0) && (value < productReg.Count);
        }

        public void SetTestValues()
        {
            productReg.Add(new Product("Egg", 34.90, 25));
            productReg.Add(new Product("Bread", 17.88, 35));
            productReg.Add(new Product("Milk", 10.5, 24));
        }

        //public property used for binding
        public BindingList<Product> Products
        {
            //return a copy of the register to be on the save side
            get
            {
                BindingList<Product> productsCopy = new BindingList<Product>();
                for (int i = 0; i < productReg.Count; i++)
                {
                    productsCopy.Add(new Product(productReg[i]));
                }
                return productReg;
            }
        }

        //GetProduct submits a reference. Thus any change in
        //receiver obj affects this instance.
        //for ex
        //	Product prod = somListOfProductRegister.AddProduct(0);
        //	prod.Name = "Bröd";
        //  ProdRegister[0].Name = "Bröd";
        //  Do not use this function outside this class, use CloneProduct (below)
        private Product GetProduct(int index)
        {
            return (Product)productReg[index];
        }

        //return a copy of the product object
        public Product CloneProduct(int index)
        {
            return ((Product)productReg[index]).Clone();
        }


        //Property for the number
        public int Number
        {
            get { return productReg.Count; }
        }

        //Info about an object from the list
        public string GetInfoString(int index)
        {
            return GetProduct(index).ToString();
        }

        //Add a new object to the list
        public int AddProduct(string name, double price, int number)
        {
            Product prod = new Product(name, price, number);
            productReg.Add(prod);
            return productReg.Count - 1;
        }

        //Add a new object to the list - overloaded function
        public int AddProduct(Product prod)
        {
            if (prod != null)
            {
                productReg.Add(prod);
            }
            return productReg.Count - 1;
        }

        //Change the values of the object at the position=index in the list
        public int ChangeProduct(Product prod, int index)
        {
            if ((prod != null) && (index >= 0) && (index < productReg.Count))
            {
                productReg.Remove(GetProduct(index));
                productReg.Insert(index, prod);
            }
            return productReg.Count - 1;  //position where the Product is saved
        }

        //Remove the object at position= index from the list
        public int DeleteProduct(int index)
        {
            productReg.Remove(GetProduct(index));
            return productReg.Count - 1;  //position where the Product is saved
        }

        //Return the sum of the price of all the products
        public double TotalSum
        {
            get
            {
                double sum = 0.0;
                for (int i = 0; i < Number; i++)
                {
                    sum += ((Product)productReg[i]).Sum;
                }

                return Math.Round(sum, 2);
            }
        }
       
    }
}
