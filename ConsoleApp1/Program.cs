using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };

            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
            Console.ReadKey();
        }

        static string[] GetAllStudents(Classroom[] classes)
        {
            string[] str = new string[classes.Length];
            var sr = classes.SelectMany(c => c.Students.Select(p => p)).ToArray();

            return str= sr.ToArray();

        }

            public class Classroom
            {
                public List<string> Students = new List<string>();
            }
           
        }
    }