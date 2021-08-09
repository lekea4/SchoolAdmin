using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Linq.Expressions;

namespace SchoolAdmin.MongoDBDemo
{
    class MongoDBService
    {
        MongoClient mongo;

        IMongoDatabase database;
        IMongoCollection<BsonDocument> teachersCollection, studentsCollection;
       



        public MongoDBService()
        {
            mongo  = new MongoClient("mongodb://localhost:27017/school_admin_db");
            database = mongo.GetDatabase("school_admin_db");
            teachersCollection = database.GetCollection<BsonDocument>("teachers");
            studentsCollection = database.GetCollection<BsonDocument>("students");
            
            

            

        }

      



        public void Insert(string collectionName, BsonDocument dataToInsert)
        {
            switch (collectionName)
            {
                case "teachers":
                     teachersCollection.InsertOne(dataToInsert);
                    //teachersCollection.InsertMany();


                    break;



                case "students":
                    
                    studentsCollection.InsertOne(dataToInsert);
                    break;



                default:
                    Console.WriteLine("Invalid collection! Only 'teachers' and 'students' are allowed");



                    //include error message



                    break;
            }
        }

        public List<BsonDocument> FetchAll(string collectionName)
        {

            List<BsonDocument> result;
            switch (collectionName)
            {
                case "teachers":
                    result = teachersCollection.Find(new BsonDocument()).ToList();
                    
                    break;



                case "students":

                    result = studentsCollection.Find(new BsonDocument()).ToList();
                    break;



                default:
                    result = null;
                    Console.WriteLine("Invalid collection! Only 'teachers' and 'students' are allowed");



                    //include error message



                    break;
            }

            return result;
        }

        public List<BsonDocument> FetchUsingSort(string collectionName, string dataToSort, string sortOrder)
        {

            List<BsonDocument> result;

            SortDefinition<BsonDocument> sort;

            switch (sortOrder)
            {
                case "combine":
                    sort = Builders<BsonDocument>.Sort.Combine(dataToSort);
                    break;

                case "descending":

                    sort = Builders<BsonDocument>.Sort.Descending(dataToSort);
                    break; 

                default :
                       
                       sort = Builders<BsonDocument>.Sort.Ascending(dataToSort); 
                    break;
            }

            


            switch (collectionName)
            {
                case "teachers":
                    result = teachersCollection.Find(new BsonDocument()).ToList();

                    break;



                case "students":

                    result = studentsCollection.Find(new BsonDocument()).ToList();
                    break;



                default:
                    result = null;
                    Console.WriteLine("Invalid collection! Only 'teachers' and 'students' are allowed");



                    //include error message



                    break;
            }

            return result;
        }


        public List<BsonDocument> UpdateWithFilter(string collectionName, KeyValuePair<string, object> filterPair, KeyValuePair<string, object>updateData)
        {

            List<BsonDocument> result;
            
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq(filterPair.Key, filterPair.Value);





            switch (collectionName)
            {
                case "teachers":
                    result = teachersCollection.Find(new BsonDocument()).ToList();

                    break;



                case "students":

                    result = studentsCollection.Find(new BsonDocument()).ToList();
                    break;



                default:
                    result = null;
                    Console.WriteLine("Invalid collection! Only 'teachers' and 'students' are allowed");

                    break;
            }

            return result;
        }



        public List<BsonDocument> FetchWithFilter(string collectionName, KeyValuePair<string, object> filterPair, string comparer)
        {

            List<BsonDocument> result;
            FilterDefinition<BsonDocument> filter; 

            switch (comparer)
            {
                case "<":
                    filter = Builders<BsonDocument>.Filter.Lt(filterPair.Key, filterPair.Value);
                    break;


                case "<=":
                    filter = Builders<BsonDocument>.Filter.Lte(filterPair.Key, filterPair.Value);
                    break;

                case ">":
                    filter = Builders<BsonDocument>.Filter.Gt(filterPair.Key, filterPair.Value);
                    break;

                case ">=":
                    filter = Builders<BsonDocument>.Filter.Gte(filterPair.Key, filterPair.Value);
                    break;

                default:
                    filter = Builders<BsonDocument>.Filter.Eq(filterPair.Key, filterPair.Value);
                    break;
            }


          

            switch (collectionName)
            {
                case "teachers":
                    result = teachersCollection.Find(new BsonDocument()).ToList();

                    break;



                case "students":

                    result = studentsCollection.Find(new BsonDocument()).ToList();
                    break;



                default:
                    result = null;
                    Console.WriteLine("Invalid collection! Only 'teachers' and 'students' are allowed");

                    break;
            }

            return result;
        }

        public void TestConnection()
        {
            //display a list of databases on this server 

            var dbList = mongo.ListDatabases().ToList();

            Console.WriteLine("This list of databases on this server is:");

            foreach (var db in dbList)
            {
                Console.WriteLine(db);
            }

        }
    }
}
