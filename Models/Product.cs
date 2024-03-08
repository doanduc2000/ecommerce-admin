using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAdmin.Models
{
    public class Product
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("categories")] public ObjectId CategoryId { get; set; }
        [BsonElement("name")] public string Name { get; set; }
        [BsonElement("price")] public double? Price { get; set; }
        [BsonElement("numberic")] public int? Numberic { get; set; }
        [BsonElement("description")] public string? Description { get; set; }
        [BsonElement("images")] public string? Image { get; set; }

        [BsonElement("createdAt")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)] public DateTime CreatedAt { get; set; }

        [BsonElement("updatedAt")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)] public DateTime UpdatedAt { get; set; }

        [BsonElement("__v")]
        public int V { get; set; }
        [BsonIgnore] public Category Category { get; set; }

    }
}
