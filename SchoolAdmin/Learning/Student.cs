using System;
using SchoolAdmin.LookUp;
using SchoolAdmin.Facilities;
namespace SchoolAdmin.Learning

{
    public class Student : ILearner
    {
        private readonly int _regNumber;
        private readonly string _fullName;
        private StudentLevel _level;


        public Student(int regNumber, string fullName)
        {
            _regNumber = regNumber;
            _fullName = fullName;
        }


        public int RegNumber
        {
            get => _regNumber;
        }


        public string Name
        {
            get => _fullName;
        }


        public StudentLevel Level
        {
            get
            {
                return _level;
            }

            set
            {
                _level = value;
            }
        }


        public void Learn()
        {
            // Additional instructions can go here
            Console.WriteLine("I am learning something interesting now.");
        }

        //    public void ReciveNewBookAlert(object source, BookEventArgs args)
        //    {
             //        Console.WriteLine($"Send email to students : \nTitle: {args.Title}, \nAuthor{args.Author}, \nTime Added {args.TimeAdded}\n\n");
            //    }
    }
}
