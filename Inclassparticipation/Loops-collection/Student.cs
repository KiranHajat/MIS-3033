using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_collection
{
    class Student
    {
       public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        private int LuckyNumber { get; set; } //since it is privtae it can not be accessed by program.cs

        public Student() //same name as class so you know its a constructor
        {
            ID = 0;
            FirstName = "";
            LastName = "";
            Birthdate = DateTime.Now;
            LuckyNumber = 0;
        }

        public Student(int id, int luckyNumber)
        {
            ID = id;
            FirstName = "";
            LastName = "";
            Birthdate = DateTime.Now;
            LuckyNumber = luckyNumber;
        }

        public string BirthdateDayOfWeek ()
        {
            return "";
        }
    }
}
