using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace TakeAwayNight.Catalog.Entities
{
    public class Category
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]//kendisi unıq bir ıd vericek.

        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
