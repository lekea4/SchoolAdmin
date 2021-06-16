using SchoolAdmin.LookUp;

namespace SchoolAdmin.Learning
{
    public interface ILearner
    {
        StudentLevel Level { get; set; }
        string Name { get; }
        int RegNumber { get; }

        void Learn();
    }
}