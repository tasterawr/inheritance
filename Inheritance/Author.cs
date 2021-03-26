using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Author
    {
        private string fname;
        private string lname;
        private int birthdate;

        public Author(string fname, string lname, int birthdate)
        {
            this.fname = fname;
            this.lname = lname;
            this.birthdate = birthdate;
        }

        public Author(Author auth)
        {
            this.fname = auth.fname;
            this.lname = auth.lname;
            this.birthdate = auth.birthdate;
        }

        public override string ToString()
        {
            return lname + " " + fname + ", Год рождения: " + birthdate;
        }

        public string FirstName
        {
            get => fname;
            set => fname = value;
        }

        public string LastName
        {
            get => lname;
            set => lname = value;
        }

        public int BirthDate
        {
            get => birthdate;
            set => birthdate = value;
        }
    }
}
