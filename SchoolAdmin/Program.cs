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
using MongoDB.Driver;
using SchoolAdmin.AdoDotnet;
using SchoolAdmin.DTO;
using SchoolAdmin.AdoDotnet.SqlDataService;
using System.Data;

namespace SchoolAdmin
{

    public class Program
    {
        //public static FellowQueries fellowQueries = new FellowQueries();

        //public static LibraryCatalogQuery catalogQuery = new LibraryCatalogQuery();

        static void Main(string[] args)
        {

            #region Working on SQLDataServices



            #region Using DataAdapter

            TeacherDataAdapterService teacherADPservice = new TeacherDataAdapterService();
            teacherADPservice.PopulateDataSet();

            DataSet teacherDS = teacherADPservice.teacherDataset;




            #endregion



            #region  Using Data Reader



            TeacherService teacherService = new TeacherService();
            StudentService studentService = new StudentService();

            ////define and insert Teacher objects

            //TeacherDTO teacher1 = new TeacherDTO() { FirstName = "Mustapha", LastName = "Rufai", MiddleName = "", Subject = "Javascript" };
            //TeacherDTO teacher2 = new TeacherDTO() { FirstName = "Frank", LastName = "Legborsi", MiddleName = "", Subject = "DevOps" };
            //TeacherDTO teacher3 = new TeacherDTO() { FirstName = "John", MiddleName = "Tony", LastName = "Ubi", Subject = "Product Design" };
            //TeacherDTO teacher4 = new TeacherDTO() { FirstName = "Tonia", MiddleName = "Seyi", LastName = "Adegbite", Subject = "Python" };

            ////sqlDbService.Insert("teachers", teacher1);
            ////sqlDbService.Insert("teachers", teacher2);

            ////define and insert student objects
            //StudentDTO student1 = new StudentDTO() { FirstName = "Edith", LastName = "Philip", MiddleName = "Amadi", Level = "Senior" };
            //StudentDTO student2 = new StudentDTO() { FirstName = "Ajao", LastName = "Olakitan", MiddleName = "", Level = "Senior" };

            ////teacherService.Insert(teacher3);
            ////teacherService.Insert(teacher4);

            ////studentService.Insert(student1);
            ////studentService.Insert(student2);


            KeyValuePair<string, object> filterPair = new KeyValuePair<string, object>("LastName", "Ajani");
           
            StudentDTO newStudent = new StudentDTO() { LastName = "Ajani", MiddleName = "Olowu" };
            //studentService.Update(filterPair, "=", newStudent);

           studentService.Delete(filterPair, "=");

            Console.WriteLine("The available students are: ");
            List<StudentDTO> students = studentService.FetchAll();

            foreach (StudentDTO student in students)
            {
                Console.WriteLine($"{student.RegNumber} \t {student.FirstName}\t\t {student.MiddleName}\t\t {student.LastName}\t\t {student.Level}");

            }

            //Console.WriteLine("\n\n\n\n");

            //Console.WriteLine("The available teachers are: ");

            //List<TeacherDTO> teachers = teacherService.FetchAll();

            //foreach (TeacherDTO teacher in teachers)
            //{
            //    Console.WriteLine($"{teacher.StaffID} \t {teacher.FirstName} \t\t\t {teacher.MiddleName} \t {teacher.LastName} \t {teacher.Subject}");
            //}




            #endregion


            #endregion


        }

    }
    
}
