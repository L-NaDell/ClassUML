using System;
using System.Collections.Generic;
using System.Text;

namespace ClassUML
{
    class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Person() { }
        public Person(string Name, string Address)
        {
            this.Name = Name;
            this.Address = Address;
        }

        public override string ToString()
        {
            return $"Person Name = {Name}, Address = {Address}";
        }
    }
}
