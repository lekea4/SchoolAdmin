using SchoolAdmin.Learning;
using SchoolAdmin.Learning.Fellow;
using SchoolAdmin.Teaching;
using SchoolAdmin.LookUp;
using System;
using System.Collections.Generic;
using SchoolAdmin.Facilities;
using SchoolAdmin.Facilities.SchoolLibrary;
using SchoolAdmin.MongoDBDemo;
using MongoDB.Bson;


namespace SchoolAdmin
{

    public class Program
    {
        //public static FellowQueries fellowQueries = new FellowQueries();

        //public static LibraryCatalogQuery catalogQuery = new LibraryCatalogQuery();

        static void Main(string[] args)
        {
            DateTime()


            #region Working on MongoDB services
            //instantiate the mongoDBservice class 
            MongoDBService dBService = new MongoDBService();

            Console.WriteLine("The available teachers are: ");

            var teachers = dBService.FetchAll("teachers");
            foreach (var teacher in teachers)
            {
                Console.WriteLine(teacher);
            }

            // dBService.TestConnection(); 

            //Create a Teacher document and insert them in the collection

           /* BsonDocument teacherDoc1 = new BsonDocument()
            {
                {"staff_id", 10001 },
                {"name", "Chief Adeleke Ayinde"},
                {"subject", "Physics" }
            };

            BsonDocument teacherDoc2 = new BsonDocument()
            {
                {"staff_id", 10002 },
                {"name", "High Chief Boyowa Odometa"},
                {"subject", "Mathematics" }
            };

            BsonDocument teacherDoc3 = new BsonDocument()
            {
                {"staff_id", 10001 },
                {"name", "Chief Chairman Temiloluwa Tegbe"},
                {"subject", "Dancing Instructor" }
            };


            //creating student document and inserting them in the collection 

            BsonDocument studentDoc1 = new BsonDocument()
            {
                {"reg_number", 50001 },
                {"full_name","Obi Cubana" },
                {"subject", "Mathematics" }
            };

            BsonDocument studentDoc2 = new BsonDocument()
            {
                {"reg_number", 50002 },
                {"full_name","Nelson Mandela" },
                {"subject", "Philosophy" }
            };

            BsonDocument studentDoc3 = new BsonDocument()
            {
                {"reg_number", 50003 },
                {"full_name","Kola Olaiya" },
                {"subject", "Physics" }
            };

            dBService.Insert("teachers", teacherDoc1);
            dBService.Insert("teachers", teacherDoc2);
            dBService.Insert("teachers", teacherDoc3);


            dBService.Insert("students", studentDoc1);
            dBService.Insert("students", studentDoc2);
            dBService.Insert("students", studentDoc2); */


#endregion


            #region previuosly worked on
            // catalogQuery.GetBooksInAscendingOrder1();

            // catalogQuery.GetBooksInAscendingOrder2();

            //  catalogQuery.GetBooksTitleAndAuthor2();

            //catalogQuery.GetBookByAuthor2();








            //fellowQueries.GetFellowsSortedByLastName1();
            //fellowQueries.GetFellowsSortedByLastName2();


            //fellowQueries.GetFellowsBorn2005SortedDesc1();
            //fellowQueries.GetFellowsBorn2005SortedDesc2();


            //fellowQueries.GetfellowsNeitherMaleNorFemale1();
            //fellowQueries.GetfellowsNeitherMaleNorFemale2();


            //fellowQueries.GetfellowsGroupedByTracks1();





            // Declare a variable of type Teacher then assign it an instance of the Teacher class
            // ITeacher firstTeacher = new Teacher (101, "Tunde Badmus");

            // Set the Subject property to a suitable value


            /*  SchoolSubject mySubject = new()
        {
            Code = 101,
            Title = "Mathematics",
            Category = "General"

        };
        firstTeacher.Subject = mySubject; 




        Create a list of type student and assign it to learner's property 
       List<ILearner> studentList = new List<ILearner> ();

        ILearner firstStudent = new Student(1001, "Betty Turner");
        firstStudent.Level = StudentLevel.JSS1;

        ILearner secondStudent = new Student (1002, "Alison Wood");
        secondStudent.Level = StudentLevel.JSS2;

        ILearner thirdStudent = new Student (1003, "Carl John");
        thirdStudent.Level = StudentLevel.SS1;

        studentList.Add(firstStudent);
        studentList.Add(secondStudent);
        studentList.Add(thirdStudent); */


            //Create an instance of the LibraryCatalog class

            // LibraryCatalog catalog = new LibraryCatalog();

            // subscribe the teacher and student to the BookAdded event

            // catalog.BookAdded += firstStudent.ReciveNe wBookAlert;
            // catalog.BookAdded += firstTeacher.ReciveNewBookAlert;


            // //add a book to the catalog 

            //catalog.AddBook(new Book()
            // {
            //     Title = "Things fall Apart",
            //     Author = "Chinua Achebe"
            // }); 






            //the objects can also be added to the student list with this format
            // studentList.AddRange(new List<Student> {firstStudent,secondStudent,thirdStudent });

            //Assigning the list of student to the teacher's learners property
            // firstTeacher.Learners = studentList;

            //Display the teacher's subject and code 
            // Console.WriteLine($"{firstTeacher.Name} teaches {firstTeacher.Subject.Title} of code {firstTeacher.Subject.Code} ");


            //display number of learners assigned to the teacher 
            // Console.WriteLine($"The number of learners assigned to {firstTeacher.Name} is {firstTeacher.Learners.Count}");

            // foreach (Student student in firstTeacher.Learners)
            // {
            //    Console.WriteLine($"Name: {student.Name} \t\tLevel: {student.Level}");
            //}


            //check if teacher's learners include a newly created student named "carl johns"
            //Student searchStudent = new Student(1003, "Carl John");
            //searchStudent.Level = StudentLevel.SS1;
            //bool isAssignedStudent = firstTeacher.Learners.Contains(searchStudent);
            //Console.WriteLine($"The search for Carl John returns: {isAssignedStudent}");



            //check if the teacher's learners include the original student named "Carl Jones"

            //bool isLearner = firstTeacher.Learners.Contains(thirdStudent);
            //Console.WriteLine($"The search for Carl John returns: {isLearner}");

            //exploring KeyValue Pair

            //KeyValuePair<int, ILearner> student1, student2, student3;
            //student1 = new KeyValuePair<int, ILearner>(5, firstStudent);




            #endregion







        }

    }
    
}
