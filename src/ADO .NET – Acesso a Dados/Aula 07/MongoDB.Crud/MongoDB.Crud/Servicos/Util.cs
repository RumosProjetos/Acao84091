using MongoDB.Crud.Modelo;

namespace MongoDB.ConsoleCrud.Servicos;

public static class Util
{
    public static Family GenerateData()
    {
        var parents = new Parent[2];
        parents[0] = new Parent { FamilyName = "Pereira", GivenName = "Pai" + Guid.NewGuid() };
        parents[1] = new Parent { FamilyName = "Pereira", GivenName = "Mãe" + Guid.NewGuid() };

        var children = new Child[3];
        children[0] = new Child { FamilyName = "Pereira", GivenName = "Primogênito" + Guid.NewGuid(), Gender = "Masculino", Grade = 40 };
        children[0] = new Child { FamilyName = "Pereira", GivenName = "Do meio" + Guid.NewGuid(), Gender = "Masculino", Grade = 35 };
        children[0] = new Child { FamilyName = "Pereira", GivenName = "Caçula" + Guid.NewGuid(), Gender = "Feminino", Grade = 25 };

        var mySamples = new Family
        {
            Address = new Address
            {
                City = "Barreiro",
                County = "Alto Seixalinho",
                State = "Setúbal"
            },
            IsRegistered = true,
            CreationDate = DateTime.Now,
            Parents = parents,
            Children = children
        };

        return mySamples;
    }

}
