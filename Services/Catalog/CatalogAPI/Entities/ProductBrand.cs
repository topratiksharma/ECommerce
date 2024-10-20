using MongoDB.Bson.Serialization.Attributes;

namespace CatalogAPI.Entities
{
    public class ProductBrand : BaseEntity
    {
        [BsonElement("Name")]
        public string Name { get; set; }
    }
}
