using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace TakeAwayNight.Catalog.Entities
{
    public class Feature
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]//kendisi unıq bir ıd vericek.

        public string FeatureId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Icon { get; set; }
    }
}
