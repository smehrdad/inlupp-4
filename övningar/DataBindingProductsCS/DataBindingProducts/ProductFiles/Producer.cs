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

namespace DataBindingProducts.ProductFiles
{
    class Producer
    {
        private string m_name;

        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }

        private Address m_address = new Address();

        public Address Address
        {
            get { return m_address; }
            set { m_address = value; }
        }
        public override string ToString()
        {
            return Address.City;
        }
	
    }
}
