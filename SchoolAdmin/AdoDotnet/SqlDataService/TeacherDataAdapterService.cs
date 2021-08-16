using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using SchoolAdmin.AdoDotnet;

namespace SchoolAdmin.AdoDotnet.SqlDataService
{
   public  class TeacherDataAdapterService
    {

        SqlConnection connection;
        SqlCommand selectCommand;
        SqlCommand updateCommand;
        SqlCommand insertCommand;
        SqlCommand deleteCommand;
        SqlDataAdapter adapter;
        public DataSet teacherDataset;
      
        public TeacherDataAdapterService()
        {
            //Create SqlConnection object
            connection = new SqlConnection("Data Source =.; Initial Catalog = SchoolAdminDB; Integrated Security = True; Pooling = False");
        }

        public void  PopulateDataSet()
        {
            //configure commands for   SqlAdapter's SELECT operation

            selectCommand = new SqlCommand("SELECT * FROM Teachers", connection);


            //create SqlAdapter OBJECT

            adapter = new SqlDataAdapter(selectCommand);

            //create DataSet object 

            teacherDataset = new DataSet();

            //fill up DataSet using qlAdapter 
            connection.Open();
            adapter.Fill(teacherDataset);
            connection.Close();

        }


    }





    /*
  TODOs:
  - Create SqlConnection object
  - Create SqlAdapter object
  - Configure commands for SqlAdapter's SELECT, INSERT, UPDATE and DELETE
  - Create DataSet object
  - Fill DataSet object with data records using the SqlAdapter object
  - Make changes to the DataSet (e.g., new record, modify record, remove record)
  - Persist the DataSet changes to the database
  - Verify that the changes in the DataSet were effected in the database
 */
}
