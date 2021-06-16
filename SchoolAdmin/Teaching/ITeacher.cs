using SchoolAdmin.Learning;
using SchoolAdmin.LookUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Teaching
{
    interface ITeacher
    {
        int StaffId { get;  }
        
        string Name { get; }

        SchoolSubject Subject { get; set; }

        List<ILearner> Learners { get; set; }

        void Teach();


    }
}
