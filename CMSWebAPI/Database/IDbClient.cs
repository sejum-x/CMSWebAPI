using CMSWebAPI.Database.Models;
using MongoDB.Driver;

namespace CMSWebAPI.Database
{
    public interface IDbClient
    {
        IMongoCollection<Student> GetStudentCollection();
    }
}
