using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace AmazonMVC
{
    public class Address
    {
        public int addressID
        {
            get => default(int);
            set
            {
            }
        }

        public string doorNumber
        {
            get => default(string);
            set
            {
            }
        }

        public string roadName
        {
            get => default(string);
            set
            {
            }
        }

        public string city
        {
            get => default(string);
            set
            {
            }
        }

        public string postcode
        {
            get => default(string);
            set
            {
            }
        }
    }
}