using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using SchoolAdmin.DTO;

namespace SchoolAdmin.AdoDotnet
{


    public class SqlDataService
    {
        SqlConnection conn;

        SqlCommand cmd;

        SqlDataAdapter adp;

        SqlDataReader rdr;



        public SqlDataService()
        {
              conn = new SqlConnection("Data Source=.;Initial Catalog=SchoolAdminDB;Integrated Security=True;Pooling=False");
        }

        public void Insert(string tableName, object dataToInsert)
        {
            string commandstring;

            switch (tableName)
            {
                case "teachers":
                    TeacherDTO teacher = (TeacherDTO)dataToInsert;
                    commandstring = $"INSERT INTO Teachers(FirstName, MiddleName, LastName, Subject)" +
                        $"VALUES('{teacher.FirstName}', '{teacher.MiddleName}', '{teacher.LastName}', '{teacher.Subject}')";
                    break;

                case "students":
                    StudentDTO student = (StudentDTO)dataToInsert;

                    commandstring = $"INSERT INTO Students(FirstName, MiddleName, LastName, Level)" +
                        $"VALUES('{student.FirstName}', '{student.MiddleName}', '{student.LastName}', '{student.Level}')";
                    break;

                default:
                    Console.WriteLine("Invalid table name! Only 'teachers' and 'students' are allowed");
                    return;
            }

            cmd = new SqlCommand(commandstring, conn);
            conn.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            Console.WriteLine($"Successfully inserted {rowsAffected} records into the '{tableName}' table");

        }


    }
}
