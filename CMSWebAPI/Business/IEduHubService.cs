using CMSWebAPI.Database.Models;
namespace CMSWebAPI.Business
{
    public interface IEduHubService
    {
        void Add(Student student);
        IEnumerable<Student> GetAllStudents();
        void ClearAllStudents();

    }
}
