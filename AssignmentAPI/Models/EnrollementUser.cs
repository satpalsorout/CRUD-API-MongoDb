using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace AssignmentAPI.Models
{
    public class EnrollementUser
    {
        [BsonElement("e_id")]
        public long id { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("email")]
        public string Email { get; set; }
        [BsonElement("phone")]
        public long Phone { get; set; }
    }
}
