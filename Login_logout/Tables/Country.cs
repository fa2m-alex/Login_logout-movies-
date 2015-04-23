using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tables
{
    public class Country
    {
        string Country_name;

        public string Country_name1
        {
            get { return Country_name; }
            set { Country_name = value; }
        }

        public override string ToString()
        {
            return Country_name1;
        }
    }
}
