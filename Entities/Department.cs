using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratroTrabalho.Entities
{
    class Department
    {
        public string Name { set; get; }

        public Department() { }

        public Department(string name)
        {
            Name = name;
        }
    }
}
