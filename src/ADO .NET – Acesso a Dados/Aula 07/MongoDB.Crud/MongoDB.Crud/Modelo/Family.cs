using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MongoDB.Crud.Modelo;

public class Family
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }
    public Parent[]? Parents { get; set; }
    public Child[]? Children { get; set; }
    public Address? Address { get; set; }
    public DateTime CreationDate { get; set; }
    public bool? IsRegistered { get; set; }
}
