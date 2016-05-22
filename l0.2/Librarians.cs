using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l0._2
{
    class Librarians : Person
    {
        string password;
        public Librarians(string name, string password) : base(name)
        {
            this.password = password;
        }

        public string getName()
        {
            return name;
        }
        public string getPassword()
        {
            return password;
        }
    }
}
