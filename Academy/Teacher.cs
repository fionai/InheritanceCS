using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Teacher:Human
    {
        public string Speciality {  get; set; }
        public int Experience { get; set; } //стаж

        // Constructors
        public Teacher(string lastName, string firstName, int age,
            string speciality, int experience):base (lastName, firstName, age)
        {
            Speciality = speciality;
            Experience = experience;
            //Console.WriteLine($"TConstructor:\t{GetHashCode().ToString("X")}");
        }
        ~Teacher()
        {
            //Console.WriteLine($"TDestructor:\t{GetHashCode().ToString("X")}");
        }
        public override string ToString()
        {
            return base.ToString()+$"|{Speciality}|{Experience}";
        }
        //public  string ToStringF()
        //{
        //    return base.ToStringF()+$"|{Speciality}|{Experience}";
        //}

    }
}
