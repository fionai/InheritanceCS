//#define ELEMENTS
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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

            //===========Writing group to file===========
            Human[] peoples = 
            {
                new Human ("Schwartzenegger", "Arnold", 78),
                new Student ("Colombo", "Franco", 91, "Heavy Metal", "LA", 98, 96),
                new Teacher ("Forsyte", "Jolion", 55, "Big Houses", 27),
                new Graduate ("Eron", "Iren", 38, "Psychology", "FR", 100, 100, "Women's etiquette in the Middle Ages"),
                new Student ("Holmes", "Sherlock", 31, "Criminology", "GB", 100, 83),
            };
            Console.WriteLine("\nJust writing:");
            foreach (var pe in peoples)
            {
                Console.WriteLine (pe.ToString ());
            }

            string filename = "group.txt";
            using (StreamWriter writer = new StreamWriter(filename, false))
            {
                foreach (var pe in peoples)
                {
                    writer.WriteLine(pe.ToString());
                }
            }

            //===========Reading from file===========
            string line = "";
            string significantLine = "";
            string[] elements;
            int n = 0;
            using (StreamReader reader = new StreamReader(filename))
            {
                while ((line = reader.ReadLine()) != null) n++;
            }

            Human[] peoplesF = new Human[n];
            n = 0;
            using (StreamReader reader = new StreamReader(filename))
            {
                while ( (line = reader.ReadLine()) != null)
                {
                    //Console.WriteLine($"Readed line:\t{line}");
                    if (line.Contains("Human")) 
                    {
                        significantLine = line.Substring(14);
                        //Console.WriteLine(significantLine);
                        elements = significantLine.Split('|');
                        peoplesF[n] = new Human(elements[0], elements[1], Convert.ToInt32(elements[2]));
                    }
                    else if (line.Contains("Student"))
                    {
                        significantLine = line.Substring(16);
                        //Console.WriteLine(significantLine);
                        elements = significantLine.Split('|');
                        peoplesF[n] = new Student(elements[0], elements[1], Convert.ToInt32(elements[2]), elements[3], elements[4], Convert.ToDouble(elements[5]), Convert.ToDouble(elements[6]));
                    }
                    else if (line.Contains("Teacher"))
                    {
                        significantLine = line.Substring(16);
                        //Console.WriteLine(significantLine);
                        elements = significantLine.Split('|');
                        peoplesF[n] = new Teacher(elements[0], elements[1], Convert.ToInt32(elements[2]), elements[3], Convert.ToInt32(elements[4]));
                    }
                    else if (line.Contains("Graduate"))
                    {
                        significantLine = line.Substring(17);
                        //Console.WriteLine(significantLine);
                        elements = significantLine.Split('|');
                        peoplesF[n] = new Graduate(elements[0], elements[1], Convert.ToInt32(elements[2]), elements[3], elements[4], Convert.ToDouble(elements[5]), Convert.ToDouble(elements[6]), elements[7]);
                    }
                    n++;
                } // end of while
            }
            //Console.WriteLine();
            Console.WriteLine("\nWriting readed from file:");
            foreach (var pe in peoplesF)
            {
                Console.WriteLine(pe.ToString());
            }
        }
    }
}
