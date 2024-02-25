using AutozMVC.Models;
namespace AutozMVC.Data.Repositories.Base
{
    public interface ICarRepository
    {
        IEnumerable<Car> AllCars { get; }
        IEnumerable<Car> GetFavoriteCars { get; }
        void AddCar(Car car);
        Car GetObjectCar(int carId);
    }
}