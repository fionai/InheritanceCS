using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Student: Human
    {
        public string Speciality { get; set; }
        public string Group { get; set; }
        public double Rating { get; set; }
        public double Attendance { get; set; }

        // Constructors
        public Student(string lastName, string firstName, int age,
            string speciality, string qroup, double rating, double attendance):base(lastName, firstName, age)
        {
            Speciality = speciality;
            Group = qroup;
            Rating = rating;
            Attendance = attendance;
            Console.WriteLine($"SConstructor:\t {GetHashCode().ToString("X")}");
        }
        public override string ToString()
        {
            return base.ToString() + $" {Speciality} {Group} {Rating} {Attendance}";
        }
    }
}

