using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tables
{
    public class Star
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        string secondName;

        public string SecondName
        {
            get { return secondName; }
            set { secondName = value; }
        }

        string birthday;

        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        /*int old;

        public int Old
        {
            get { return old; }
            set { old = value; }
        }*/

        int careerDate;

        public int CareerDate
        {
            get { return careerDate; }
            set { careerDate = value; }
        }

        string bornPlace;

        public string BornPlace
        {
            get { return bornPlace; }
            set { bornPlace = value; }
        }

        public override string ToString()
        {
            return Name + " " + SecondName;
        }
    }
}
