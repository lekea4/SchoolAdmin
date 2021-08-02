using SchoolAdmin.Facilities;
using SchoolAdmin.Learning;
using SchoolAdmin.LookUp;
using System.Collections.Generic;

namespace SchoolAdmin.Teaching
{
    internal interface ITeacher
    {
        int StaffId { get; }

        string Name { get; }

        SchoolSubject Subject { get; set; }

        List<ILearner> Learners { get; set; }

        void Teach();
       // void ReciveNewBookAlert(object source, BookEventArgs args);
    }
}