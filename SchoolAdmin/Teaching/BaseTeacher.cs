using SchoolAdmin.Facilities;
using SchoolAdmin.Learning;
using SchoolAdmin.LookUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Teaching
{
    abstract class BaseTeacher : ITeacher
    {
        public int StaffId { get; }

        public string Name { get; }

        public SchoolSubject Subject { get; set; }
        public List<ILearner> Learners { get; set; }

        /*public void ReciveNewBookAlert(object source, BookEventArgs args)
        {
          
        } */

        public abstract void Teach();
       
    }

}
