using APBD_06_WebApi.Models;

namespace APBD_06_WebApi;

public static class Database
{
    
    public static List<Animal> Animals = new List<Animal>()
    {
        new Animal() { Id = 1, Name = "Burek", Type = "kot", Mass = 2000.0, FurColour = "bury" },
        new Animal() { Id = 2, Name = "Bobik", Type = "pies", Mass = 1500.0, FurColour = "brazowy" },
        new Animal() { Id = 3, Name = "Mruczek", Type = "kot", Mass = 1700.0, FurColour = "bialy" }
    };
}