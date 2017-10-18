using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermReview
{
    class Course
    {
        //always start with variables (private members), then move on to properties (public) and then constructors (empty and overloaded)

            //variables
        private string cid;
        private string name;
        private int credithours;
        
        //properties
        public string CID
        {
            set { cid = value; }
            get { return cid; }
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        
        public int CreditHours
        {
            set { credithours = value; }
            get { return credithours; }
        }

        //constructors 
        //base (empty)
        public Course()
        {
            CID = "";
            Name = "";
            CreditHours = 0;
        }
        //overloaded (filled with arguments)
        public Course(string courseid, string nm, int crdhrs)
        {
            CID = courseid;
            Name = nm;
            CreditHours = crdhrs;
        }
    }
}
