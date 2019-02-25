using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF1
{
    class Application
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }

        public Application ()
        {
            Name = "";
            Address = "";
            ZipCode = 0;
        }
        public Application(string name, string address, int zipCode)
        {
            Name = name;
            Address = address;
            ZipCode = zipCode;
        }
        //public string override ToString()
        //{

        //}
    }
}
