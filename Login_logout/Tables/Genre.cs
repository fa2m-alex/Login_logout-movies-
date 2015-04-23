using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tables
{
    public class Genre
    {
        string genreName;

        public string GenreName
        {
            get { return genreName; }
            set { genreName = value; }
        }

        public override string ToString()
        {
            return genreName;
        }
    }
}
