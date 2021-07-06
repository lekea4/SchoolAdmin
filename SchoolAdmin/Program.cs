using SchoolAdmin.Learning;
using SchoolAdmin.Teaching;
using SchoolAdmin.LookUp;
using System;
using System.Collections.Generic;

namespace SchoolAdmin
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declare a variable of type Teacher then assign it an instance of the Teacher class
            ITeacher firstTeacher = new Teacher (101, "Tunde Badmus");

            // Set the Subject property to a suitable value
            //firstTeacher.Subject = "Mathematics";

            SchoolSubject mySubject = new()
            {
                Code = 101,
                Title = "Mathematics",
                Category = "General"

            };
            firstTeacher.Subject = mySubject;


            //Create a list of type student and assign it to learner's property 
            List<ILearner> studentList = new List<ILearner> ();

            ILearner firstStudent = new Student (1001, "Betty Turner");
            firstStudent.Level = StudentLevel.JSS1;

            ILearner secondStudent = new Student (1002, "Alison Wood");
            secondStudent.Level = StudentLevel.JSS2;

            ILearner thirdStudent = new Student (1003, "Carl John");
            thirdStudent.Level = StudentLevel.SS1;

            studentList.Add(firstStudent);
            studentList.Add(secondStudent);
            studentList.Add(thirdStudent);

            //the objects casn also be added to the student list with this format
            // studentList.AddRange(new List<Student> {firstStudent,secondStudent,thirdStudent });

            //Assigning the list of student to the teacher's learners property
            firstTeacher.Learners = studentList;

            //Display the teacher's subject subject and code 
            Console.WriteLine($"{firstTeacher.Name} teaches {firstTeacher.Subject.Title} of code {firstTeacher.Subject.Code} ");


            //display number of learners assigned to the teacher 
            Console.WriteLine($"The number of learners assigned to {firstTeacher.Name} is {firstTeacher.Learners.Count}");

            foreach (Student student in firstTeacher.Learners)
            {
                Console.WriteLine($"Name: {student.Name} \t\tLevel: {student.Level}");
            }


            //check if teacher's learners include a newly created student named "carl johns"
            Student searchStudent = new Student(1003, "Carl John");
            searchStudent.Level = StudentLevel.SS1;
            bool isAssignedStudent = firstTeacher.Learners.Contains(searchStudent);
            Console.WriteLine($"The search for Carl John returns: {isAssignedStudent}");



            //check if the teacher's learners include the original student named "carl jones"

            bool isLearner = firstTeacher.Learners.Contains(thirdStudent);
            Console.WriteLine($"The search for Carl John returns: {isLearner}");

            //// Exploring KeyValuePair<TKey, TValue> type
            //KeyValuePair<int, ILearner> student1, student2, student3;
            //student1 = new KeyValuePair<int, ILearner>(5, firstStudent);
            //student2 = new KeyValuePair<int, ILearner>(7, secondStudent);
            //student3 = new KeyValuePair<int, ILearner>(10, thirdStudent);

            //// Exploring Dictionary<TKey, TValue> type
            //Dictionary<int, ILearner> studentDictionary;
            //studentDictionary = new Dictionary<int, ILearner>();
            //studentDictionary.Add(5, firstStudent);
            //studentDictionary.Add(7, secondStudent);
            //studentDictionary.Add(10, thirdStudent);

            //foreach(KeyValuePair<int, ILearner> kvp in studentDictionary)
            //{
            //    Console.WriteLine($"Key is {kvp.Key} \t Value is {kvp.Value.Name}");
            //}










        }
    }
}
