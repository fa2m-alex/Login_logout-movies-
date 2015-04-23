using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tables
{
    public class Studio
    {
        string studioName;

        public string StudioName
        {
            get { return studioName; }
            set { studioName = value; }
        }

        public override string ToString()
        {
            return studioName;
        }
    }
}
