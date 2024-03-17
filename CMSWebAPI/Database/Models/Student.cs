using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace CMSWebAPI.Database.Models
{
    public class Student
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Group { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public DateTime Birthday { get; set; }

        public string Status { get; set; }
    }
}
