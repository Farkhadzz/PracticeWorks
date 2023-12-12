using System.ComponentModel;

namespace TrafficPolice.Models;

public class FineModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public bool isPaid { get; set;}
    public Category category { get; set; }
}

public enum Category {
    Speed,
    Parking,
}