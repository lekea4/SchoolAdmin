using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Learning.Fellow
{
    class FellowQueries
    {
        // STEP ONE- Establish the data-source, a list of fellow objects
        public IEnumerable<Fellow> fellows = new List<Fellow>()
        {
            new Fellow() {FirstName= "Ebenezer", LastName= "Ogungbe", Track= "Javascript", Gender= "Male", DateOfBirth = new DateTime(1999, 4, 15)},

            new Fellow() {FirstName= "Abolaji", LastName= "Adebayo",  Track= "DevOps", Gender= "Male", DateOfBirth = new DateTime(1800, 4, 20)},

            new Fellow() {FirstName= "Jane", LastName="Okeke", Track= "DotNet", Gender= "Female", DateOfBirth = new DateTime(2002, 9, 1)},

            new Fellow() {FirstName= "Segun", LastName="Abiodun", Track= "Javascript", Gender= "Non-Binary", DateOfBirth = new DateTime(2018, 6, 19)},

            new Fellow() {FirstName= "Temilola", LastName="Tegbe", Track= "DotNet", Gender= "Undisclosed", DateOfBirth = new DateTime(1999, 10, 7)},

            new Fellow() {FirstName= "AbduRahmon", LastName="Olusokan", Track= "DevOps", Gender= "Female", DateOfBirth = new DateTime(2005, 3, 15)},

            new Fellow() {FirstName= "Fatimah", LastName="Akanbi ", Track= "Javascript", Gender= "Female", DateOfBirth = new DateTime(2010, 11, 13)},

            new Fellow() {FirstName= "Hope", LastName="Ndudim", Track= "DotNet", Gender= "Male", DateOfBirth = new DateTime(2005, 7, 4)},

            new Fellow() {FirstName= "Solomon", LastName="Akinola", Track= "Javascript", Gender= "Male", DateOfBirth = new DateTime(1978, 12, 25)},

            new Fellow() {FirstName= "Rabo", LastName="Yusuf", Track= "Javascript", Gender= "Undisclosed", DateOfBirth = new DateTime(1978, 12, 25)},

            new Fellow() {FirstName= "Valentine", LastName="Madu", Track= "Javascript", Gender= "Male", DateOfBirth = new DateTime(2002, 11, 29)}

        };





    /*
     QUERY EXPECTATIONS:

    -----------------------------------------------------------------------------------------------------------------
     1. Fetch all fellows, sorted by last name in ascending 
     2. Fetch all fellows born in the year 2005 and later, sorted in descending order of date of birth 
     3. Fetch all fellows who are neither male or female 
     4. Fetch all fellows who were not born between 1995 and 2004, and grouped by their respective tracks
     5. Fetch all fellows grouped by tracked and sorted in ascending order of first name


     ---------------------------------------------------------------------------------------------------------------------

     */

    //STEP TWO - Write a bunch of queries using expression syntax 

    // 1. Fetch all fellows, sorted by last name in ascending

        //A. Expression Syntax Query
    public void GetFellowsSortedByLastName1()
        {
            IEnumerable<Fellow> lastNameSortedQuery = from fellow in fellows
                                                      orderby fellow.LastName descending
                                                      select fellow;

            Console.WriteLine("List of fellows, sorted by last name in descending order...... using EXPRESSION Syntax Query\n");

            Console.WriteLine("First Name\t\tLast Name\t\tDate of Birth\t\tGender\t\tTrack");



            foreach (Fellow objFellow in lastNameSortedQuery)
            {
                Console.WriteLine($"{objFellow.FirstName}\t\t{objFellow.LastName}\t\t{objFellow.DateOfBirth.ToShortDateString()}\t\t{objFellow.Gender}\t\t{objFellow.Track}");
            }

        }


        //2. Fetch all fellows born in the year 2005 and later, sorted in descending order of date of birth 
        public void GetFellowsBorn2005SortedDesc1()
        {
            IEnumerable<Fellow> dob2005SortQuery = from fellow in fellows
                                                   where fellow.DateOfBirth.Year >= 2005
                                                   orderby fellow.DateOfBirth descending
                                                   select fellow;

            Console.WriteLine("List of fellows,born in the year 2005 and later...... using EXPRESSION Syntax Query\n");

            Console.WriteLine("First Name \t\tLast Name \t\tDate of Birth \t\tGender \t\tTrack");


            foreach (Fellow objFellow in dob2005SortQuery)
            {
                Console.WriteLine($"{objFellow.FirstName}\t\t{objFellow.LastName}\t\t{objFellow.DateOfBirth.ToShortDateString()}\t\t{objFellow.Gender}\t\t{objFellow.Track}");

            }
        }


        //     3. Fetch all fellows who are neither male or female

        public void GetfellowsNeitherMaleNorFemale1()
        {
            IEnumerable<Fellow> neitherMaleNorFemaleQuery = from fellow in fellows
                                                            where fellow.Gender != "Male" && fellow.Gender != "Female"
                                                            select fellow;

            Console.WriteLine("List of fellows,neither male nor female...... using EXPRESSION Syntax Query\n");

            Console.WriteLine("First Name \t\tLast Name \t\tDate of Birth \t\tGender \t\tTrack");

            foreach (Fellow objFellow in neitherMaleNorFemaleQuery)
            {
                Console.WriteLine($"{objFellow.FirstName}\t\t{objFellow.LastName}\t\t{objFellow.DateOfBirth.ToShortDateString()}\t\t{objFellow.Gender}\t\t{objFellow.Track}");

            }
        }

        // 4. Fetch all fellows who were not born between 1995 and 2004, and grouped by their respective tracks

        public void GetfellowsGroupedByTracks1()
        {
            IEnumerable<IGrouping<string,Fellow>> groupedByTracksQuery = from fellow in fellows
                                                       where fellow.DateOfBirth.Year <= 1995 || fellow.DateOfBirth.Year >= 2004
                                                       group fellow by fellow.Track;


            Console.WriteLine("List of fellows,not born between 1995 and 2004, and grouped by their respective tracks...... using EXPRESSION Syntax Query\n");

            Console.WriteLine("First Name \t\tLast Name \t\tDate of Birth \t\tGender \t\tTrack");

            foreach (var objGroup in groupedByTracksQuery)
            {
                Console.WriteLine(objGroup.Key.ToUpper());

                foreach (Fellow objFellow in objGroup)
                {
                    Console.WriteLine($"{objFellow.FirstName}\t\t{objFellow.LastName}\t\t{objFellow.DateOfBirth.ToShortDateString()}\t\t{objFellow.Gender}\t\t{objFellow.Track}");

                }


            }
      
        
        }




        //STEP THREE - Repeat the above queries using method syntax 
        // 1. Fetch all fellows, sorted by last name in ascending
        public void GetFellowsSortedByLastName2()
        {
            IEnumerable<Fellow> lastNameSortedQuery = fellows.OrderByDescending(f => fellows);
            Console.WriteLine("\n\nList of fellows, sorted by last name in descending order...... using METHOD SYNTAX\n");

            Console.WriteLine("\n\nFirst Name \t\tLast Name \t\tDate of Birth \t\tGender \t\tTrack\n");



            foreach (Fellow objFellow in lastNameSortedQuery)
            {
                Console.WriteLine($"{objFellow.FirstName} \t\t{objFellow.LastName} \t\t{objFellow.DateOfBirth.ToShortDateString()} \t\t{objFellow.Gender} \t\t{objFellow.Track}");
            }

        }



        //2. Fetch all fellows born in the year 2005 and later, sorted in descending order of date of birth 
        public void GetFellowsBorn2005SortedDesc2()
        {
            IEnumerable<Fellow> dob2005SortQuery = fellows
                .Where(f => f.DateOfBirth.Year >= 2005)
                .OrderByDescending(f => f.DateOfBirth);

            Console.WriteLine("\n\nList of fellows,born in the year 2005 and later...... using EXPRESSION Syntax Query");

            Console.WriteLine("\n\nFirst Name\t\tLast Name\t\tDate of Birth\t\tGender\t\tTrack\n");

            foreach (Fellow objFellow in dob2005SortQuery)
            {
                Console.WriteLine($"{objFellow.FirstName} \t\t{objFellow.LastName} \t\t{objFellow.DateOfBirth.ToShortDateString()} \t\t{objFellow.Gender} \t\t{objFellow.Track}");

            }

        }

        //3. Fetch all fellows who are neither male or female

        public void GetfellowsNeitherMaleNorFemale2()
        {
            IEnumerable<Fellow> neitherMaleNorFemaleQuery = fellows.Where(f => f.Gender != "Male" && f.Gender != "Female");

            Console.WriteLine("\n\nList of fellows,neither male nor female...... using METHOD Syntax Query");

            Console.WriteLine("\n\nFirst Name\t\tLast Name\t\tDate-of-Birth\t\tGender\t\tTrack");

            foreach (Fellow objFellow in neitherMaleNorFemaleQuery)
            {
                Console.WriteLine($"{objFellow.FirstName}\t\t\t{objFellow.LastName}\t\t\t{objFellow.DateOfBirth.ToShortDateString()}\t\t{objFellow.Gender}\t{objFellow.Track}");

            }
        }


        // 4. Fetch all fellows who were not born between 1995 and 2004, and grouped by their respective tracks

        public void GetfellowsGroupedByTracks2()
        {
            IEnumerable<IGrouping<string, Fellow>> groupByTrackQuery = fellows
                .Where(f => f.DateOfBirth.Year <= 1995 || f.DateOfBirth.Year >= 2004).GroupBy(f => f.Track);


            Console.WriteLine("\n\nList of fellows,neither male nor female...... using METHOD Syntax Query");

            Console.WriteLine("\n\nFirst Name\t\tLast Name\t\tDate-of-Birth\t\tGender\t\tTrack");


            foreach (var objGroup in groupByTrackQuery)
            {
                Console.WriteLine(objGroup.Key.ToUpper());

                foreach (Fellow objFellow in objGroup)
                {
                    Console.WriteLine($"{objFellow.FirstName}\t\t\t{objFellow.LastName}\t\t\t{objFellow.DateOfBirth.ToShortDateString()}\t\t{objFellow.Gender}\t{objFellow.Track}");

                }
            }
            

            }
        }





















    }

























