﻿using MongoDB.Bson.Serialization.Attributes;

namespace CatalogAPI.Entities
{
    public class ProductType : BaseEntity
    {
        [BsonElement("Name")]
        public string Name { get; set; }
    }
}
