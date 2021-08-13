using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using SchoolAdmin.DTO;

namespace SchoolAdmin.AdoDotnet.SqlDataService
{
   public class TeacherService
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adp;
        SqlDataReader rdr;



        public TeacherService()
        {
            conn = new SqlConnection("Data Source=.;Initial Catalog=SchoolAdminDB;Integrated Security=True;Pooling=False");
        }

        public void Insert (TeacherDTO dataToInsert)
        {
            string commandString = $"INSERT INTO Teachers(FirstName, MiddleName, LastName, Subject)" +
                $"VALUES ('{dataToInsert.FirstName}', '{dataToInsert.MiddleName}', '{dataToInsert.LastName}', '{dataToInsert.Subject}')";

            cmd = new SqlCommand(commandString, conn);
            conn.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            Console.WriteLine($"Successfully inserted {rowsAffected} records into the 'Teachers' table.");

        }

        public List<TeacherDTO> FetchAll()
        {
            List<TeacherDTO> result = new List<TeacherDTO>();

            string commandString = "SELECT * FROM Teachers";
            cmd = new SqlCommand(commandString, conn);
            conn.Open();
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                result.Add(new TeacherDTO
                {
                    StaffID = (int)rdr["StaffID"],
                    FirstName = (string)rdr["FirstName"],
                    MiddleName = rdr["MiddleName"] == DBNull.Value ? string.Empty : (string)rdr["MiddleName"],
                    LastName = (string)rdr["LastName"],
                    Subject = (string)rdr["Subject"]

                });
            }

            conn.Close();

            return result;
        }

        public List<TeacherDTO> FetchWithFilter(KeyValuePair<string, object>filterPair, string comparer)
        {
            List<TeacherDTO> result = new List<TeacherDTO>();

            //the are two ways to go about this; 
            //1. With Parameters
            //2. Without Parameters   

            //1. SQL without parameters 

            string commandString = "SELECT * FROM Teachers WHERE" + $"{filterPair.Key} {comparer} '{filterPair.Value}'";


            //2. SQL Query with parameters 
            // string commandStr2 = "SELECT * FROM Teachers WHERE " + $"{filterPair.Key} {comparer} @param";
            //string commandStr4 = "SELECT * FROM Teachers WHERE Subject = @p1 OR Subject = @p2 OR Subject = @p3";

            cmd = new SqlCommand(commandString, conn);

            //// Specify parameters here, if any
            //cmd.Parameters.AddWithValue("param", filterPair.Value);
            //cmd.Parameters.AddWithValue("p1", "Physics");
            //cmd.Parameters.AddWithValue("p2", "Chemistry");
            //cmd.Parameters.AddWithValue("p3", "Biology");

            conn.Open();
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                result.Add(new TeacherDTO
                {
                    StaffID = (int)rdr["StaffID"],
                    FirstName = (string)rdr["FirstName"],
                    MiddleName = rdr["MiddleName"] == DBNull.Value ? string.Empty : (string)rdr["MiddleName"],
                    LastName = (string)rdr["LastName"],
                    Subject = (string)rdr["Subject"]
                }


                    );
            }
            conn.Close();

            return result;
        }
        public void Update(KeyValuePair<string, object>filterPair, string comparer, TeacherDTO newData)
        {
            string filterString = "WHERE" + $"{filterPair.Key} {comparer} '{filterPair.Value}'";

            string updateString = newData.FirstName == null ? "" : $"FirstName = '{newData.FirstName}',";
            updateString += newData.MiddleName == null ? "" : $"MiddleName = '{newData.MiddleName}',";
            updateString += newData.LastName == null ? "" : $"LastName = '{newData.LastName}',";
            updateString += newData.Subject == null ? "" : $"Subject = '{newData.Subject}',";

            string commandString = $"UPDATE Teachers SET " + updateString.TrimEnd(',') + filterString;

            cmd = new SqlCommand(commandString, conn);
            conn.Open();

            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            Console.WriteLine($"Successfully updated{rowsAffected} records in the 'Teachers' Table.");
        
        }

        public void Delete (KeyValuePair<string, object>filterPair, string comparer)
        {
            string commandString = $"DELETE FROM Teachers WHERE {filterPair.Key} {comparer} '{filterPair.Value}'";

            cmd = new SqlCommand(commandString, conn);

            conn.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            Console.WriteLine($"Successfully deleted{rowsAffected} records in the 'Teachers' Table.");


        }
    }
}
