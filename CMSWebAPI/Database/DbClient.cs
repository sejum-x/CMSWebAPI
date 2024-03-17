using CMSWebAPI.Database.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace CMSWebAPI.Database {    

    public class DbClient : IDbClient
    {
        private readonly IMongoDatabase _database;
        public DbClient(IOptions<DbConfig> dbConfig)
        {
            var Client = new MongoClient(dbConfig.Value.Connection_String);
            _database = Client.GetDatabase(dbConfig.Value.Database_Name);
        }


        public IMongoCollection<Student> GetStudentCollection() => 
            _database.GetCollection<Student>("Students");
    }
}
