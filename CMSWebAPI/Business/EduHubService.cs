using CMSWebAPI.Database;
using CMSWebAPI.Database.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace CMSWebAPI.Business
{
    public class EduHubService : IEduHubService
    {
        private readonly IMongoCollection<Student> _studentCollection;

        public EduHubService(IDbClient dbClient) {
            _studentCollection = dbClient.GetStudentCollection();
        }

        public void Add(Student student)
        {
            student.Id = ObjectId.GenerateNewId().ToString();

            _studentCollection.InsertOne(student);
        }
        public IEnumerable<Student> GetAllStudents()
        {
            return _studentCollection.Find(_ => true).ToList();
        }
        public void ClearAllStudents()
        {
            _studentCollection.DeleteMany(_ => true);
        }
    }
}
