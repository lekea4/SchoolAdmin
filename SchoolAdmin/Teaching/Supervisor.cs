using SchoolAdmin.Facilities;
using SchoolAdmin.Learning;
using SchoolAdmin.LookUp;
using System.Collections.Generic;

namespace SchoolAdmin.Teaching
{
    internal class Supervisor : ITeacher
    {
        private readonly int _staffId;
        private readonly string _fullName;
        private SchoolSubject _subject;
        private List<ILearner> _learners;

        public Supervisor(int staffId, string fullName)
        {
            _staffId = staffId;
            _fullName = fullName;
        }

        public int StaffId { get; }

        public string Name { get; }

        public SchoolSubject Subject { get; set; }
        public List<ILearner> Learners { get; set; }

        public void Teach()
        {
        }

        public void Supervise()
        {
        }

        public void GenerateReport()
        {
        }

        public void ReciveNewBookAlert(object source, BookEventArgs args)
        {
            
        }
    }
}