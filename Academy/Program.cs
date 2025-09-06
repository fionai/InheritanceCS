//#define ELEMENTS
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;



//StackOverflow форум

namespace Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if ELEMENTS
            Human human = new Human("Schwartzenegger", "Arnold", 78);
            Console.WriteLine(human);

            Student student = new Student("Colombo", "Franco", 91, "Heavy Metal", "LA", 98, 96);
            Console.WriteLine(student);

            Teacher teacher = new Teacher("Forsyte", "Jolion", 55, "Big Houses", 27);
            Console.WriteLine(teacher);

            Graduate graduate = new Graduate("Eron", "Iren", 38, "Psychology", "FR", 100, 100, "Women etiquette in the Middle Ages");
            Console.WriteLine(graduate); 
#endif

            Human[] peoples = 
            {
                new Human ("Schwartzenegger", "Arnold", 78),
                new Student ("Colombo", "Franco", 91, "Heavy Metal", "LA", 98, 96),
                new Teacher ("Forsyte", "Jolion", 55, "Big Houses", 27),
                new Graduate ("Eron", "Iren", 38, "Psychology", "FR", 100, 100, "Women's etiquette in the Middle Ages"),
                new Student ("Holmes", "Sherlock", 31, "Criminology", "GB", 100, 83),
            };
            Console.WriteLine("\nWriting:");
            foreach (var pe in peoples)
            {
                Console.WriteLine (pe.ToString ());
            }

            string filename = "group.txt";
            using (StreamWriter writer = new StreamWriter(filename, false))
            {
                //writer.WriteLine("_*_*_");
                foreach (var pe in peoples)
                {
                    writer.WriteLine(pe.ToString());
                }
            }
            Console.WriteLine("\nWriting from file:");
            string line = "";
            using (StreamReader reader = new StreamReader(filename))
            {
                while ( (line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.WriteLine();
        }
    }
}
