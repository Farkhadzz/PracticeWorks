using AutozMVC.Models;

namespace AutozMVC.ViewModel;

public class CarsListViewModel {
    public IEnumerable<Car> AllCars { get; set; }
    public string carCategory { get; set; }
}