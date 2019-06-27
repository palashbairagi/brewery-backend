using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace brewerybackend.Models
{
    public class Brewery
    {
        [BsonId]
        public long Id { set; get; }

        [BsonElement("name")]
        public string Name { set; get; }

        [BsonElement("brewery_type")]
        public string Type { set; get; }

        [BsonElement("street")]
        public string Street { set; get; }

        [BsonElement("city")]
        public string City { set; get; }

        [BsonElement("postal_code")]
        public string PostalCode { set; get; }

        [BsonElement("state")]
        public string State { set; get; }

        [BsonElement("country")]
        public string Country { set; get; }

        [BsonElement("latitude")]
        public string Latitude { set; get; }

        [BsonElement("longitude")]
        public string Longitude { set; get; }

        [BsonElement("phone")]
        public string Phone { set; get; }

        [BsonElement("website_url")]
        public string Website { set; get; }
    }
}
