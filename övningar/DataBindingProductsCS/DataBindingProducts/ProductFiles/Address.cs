using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataBindingProducts.ProductFiles
{
    class Address
    {
        private string m_Street = String.Empty;
        private string m_ZipCode = String.Empty;
        private string m_City = String.Empty;
        private string m_Country = String.Empty;

        //property used by binding
        //why can't we use the ToString()?  Read documentatins
        public string Info 
        {
            get { return ToString(); }
        }

        public string Country
        {
            get { return m_Country; }
            set { m_Country = value; }
        }

        public string City
        {
            get { return m_City; }
            set { m_City = value; }
        }

        public string ZipCode
        {
            get { return m_ZipCode; }
            set { m_ZipCode = value; }
        }

        public string Street
        {
            get { return m_Street; }
            set { m_Street = value; }
        }
        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", m_Street, m_ZipCode, m_City);
        }
    }
}
