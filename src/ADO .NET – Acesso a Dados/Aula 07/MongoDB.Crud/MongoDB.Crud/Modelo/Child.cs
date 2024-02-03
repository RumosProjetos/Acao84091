namespace MongoDB.Crud.Modelo;

public class Child
{
    public string? FamilyName { get; set; }
    public string? GivenName { get; set; }
    public string? Gender { get; set; }
    public int Grade { get; set; }
    public Pet[]? Pets { get; set; }
}
