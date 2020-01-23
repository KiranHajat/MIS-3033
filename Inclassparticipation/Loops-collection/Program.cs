using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] studentIds = new int[3];
            string[] studentFirstName = new string[3];
            string[] studentLastName =  { "tim", "kim", "nim" };
            studentIds[0] = 1;
            studentIds[1] = 2;
            studentIds[2] = 3;

            studentFirstName[0] = "tahi";
            studentFirstName[1] = "neil";
            studentFirstName[2] = "hamber";

            for (int i = 0; i <studentIds.Length; i++)
            {
                Console.WriteLine($"{studentLastName[i]}, {studentFirstName[i]}, [{studentIds[i]}].");
            }
            // Dictionary -key/value pairs

            Dictionary<int, string> students = new Dictionary<int, string>();
            students.Add(1, "Kattie Harris");
            students.Add(2, "Adam Ackerman");
            students.Add(3, "Harry Smith");

            /* if (students.ContainsKey(1))
             {
                 students[1] = "Some new Value"
             }
             else
             {
                 students.Add(1, "some value")
             } */

            foreach (var key in students.Keys)
            {
                Console.WriteLine($"{students[key]}.");  //insert
            }


            //class
            List<Student> studs = new List<Student>();

            Student katie = new Student();
            katie.FirstName = "katie";
            katie.LastName = "harris";
            katie.ID = 1;
            katie.Birthdate = Convert.ToDateTime("3/11/1998");

            studs.Add(katie);
            for (int i = 0; i < studentIds.Length; i++)
            {
                Student s = new Student();
                s.FirstName = studentFirstNames[i];
                s.FirstName = studentFirstNames[i];


            }
            Console.ReadKey();
        }
    }
}
