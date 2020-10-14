﻿using Gestalt.Common.DAL.MongoDBImpl;
using Gestalt.Common.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Gestalt.Common.DAL.Entities
{
    public class RequestEntity : Request, IIdentifiable
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId EntityId { get; set; }
    }
}