namespace AutozMVC.Data.Interfaces;
using AutozMVC.Models;

public interface IAllCars {
    IEnumerable<Car> AllCars { get; }
    IEnumerable<Car> GetFavoriteCars { get; set; }
    Car getObjectCar(int carId);
}