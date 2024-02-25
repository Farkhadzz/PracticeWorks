#pragma warning disable 8618
namespace AutozMVC.Models;

public class Category {
    public int Id { get; set; }
    public string CategoryName{ get; set; }
    public string Description { get; set; }
    public List<Car> Cars { get; set; }
}