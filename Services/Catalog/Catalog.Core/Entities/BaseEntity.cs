using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace CatalogAPI.Entities
{
    public class BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
    }
}
