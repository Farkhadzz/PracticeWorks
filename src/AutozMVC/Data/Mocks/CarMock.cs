using AutozMVC.Data.Interfaces;
using AutozMVC.Data.Mocks;
using AutozMVC.Models;

public class CarMock : IAllCars
{

    private readonly CategoryMock _allCategoires = new CategoryMock();
    public IEnumerable<Car> AllCars
    {
        get
        {
            return new List<Car> {
             new Car {
             Name = "BMW",
             Model = "M5 E60",
             ShortDesc = "For your speed",
             LongDesc = "Family sedan with V10 engine and SMG gearbox",
             Img = "https://www.tejsspecialistcars.co.uk/wp-content/uploads/2018/05/IMG_4057.jpg",
             Price = 65000,
             IsFavorite = true,
             Available = true,
             Category = _allCategoires.AllCategories.Last()
             },

         new Car {
             Name = "Mercedes Benz",
             Model = "CLS 350",
             ShortDesc = "For your comfort",
             LongDesc = "Amazing car for your comfort with speed",
             Img = "https://www.alainclass.com/wp-content/uploads/inventory/a1a0d3c1-57c5-4213-93fc-21c7de1713da/_MG_8730.JPG",
             Price = 32500,
             IsFavorite = true,
             Available = true,
             Category = _allCategoires.AllCategories.Last()
         }
    };
        }
    }

    public IEnumerable<Car> GetFavoriteCars { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public Car getObjectCar(int carId)
    {
        throw new NotImplementedException();
    }
};