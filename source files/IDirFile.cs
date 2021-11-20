using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace AudioCodes_First_Task___Almog_Geva
{
    public interface IDirFile : IIdable
    {
        [BsonId]
        string Id { get; }
        [BsonElement("name")]
        string Name { get; set; }
        [BsonElement("extension")]
        string Extension { get; }
        [BsonElement("size")]
        long ByteSize { get; }
        [BsonElement("path")]
        string Path { get; }

    }
}
