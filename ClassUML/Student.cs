using System;
using System.Collections.Generic;
using System.Text;

namespace ClassUML
{
    class Student : Person
    {
        private string Program { get; set; }
        private int Year { get; set; }
        private double Fee { get; set; }

        public Student() { }
        public Student(string Name, string Address, string Program, int Year, double Fee)
            : base(Name, Address)
        {
            this.Program = Program;
            this.Year = Year;
            this.Fee = Fee;
        }

        public override string ToString()
        {
            return $"Sudent {base.ToString()}, Program = {Program}, Year = {Year}, Fee = {Fee}";
            //return $"Student [Person [Name = {Name}, Address = {Address}], Program = {Program}, Year = {Year}, Fee = {Fee}]";
        }
    }
}
