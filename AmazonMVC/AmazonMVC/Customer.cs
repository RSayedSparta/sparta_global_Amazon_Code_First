using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace AmazonMVC
{
    public class Customer
    {
        public int customerID
        {
            get => default(int);
            set
            {
            }
        }

        public string firstName
        {
            get => default(string);
            set
            {
            }
        }

        public string lastNmae
        {
            get => default(string);
            set
            {
            }
        }

        public Address address
        {
            get => default(Address);
            set
            {
            }
        }
    }
}