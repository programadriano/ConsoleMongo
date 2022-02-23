using ConsoleMongo.Models;
using MongoDB.Bson.Serialization.Attributes;

namespace ConsoleMongo.Models
{
    public class News : BaseEntity
    {
        [BsonElement("hat")]
        public string Hat { get; set; }

        [BsonElement("title")]
        public string Title { get; set; }

        [BsonElement("text")]
        public string Text { get; set; }

        [BsonElement("author")]
        public string Author { get; set; }

        [BsonElement("img")]
        public string Img { get; set; }
    }
}
