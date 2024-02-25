#pragma warning disable 8618
namespace AutozMVC.Models;

public class Car {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Model { get; set; }
    public string ShortDesc { get; set;}
    public string LongDesc { get; set; }
    public string Img { get; set; }
    public ushort Price { get; set; }
    public bool IsFavorite { get; set; }
    public bool Available { get; set; }
    public int CategordId { get; set; }
    public virtual Category Category { get; set; }
}