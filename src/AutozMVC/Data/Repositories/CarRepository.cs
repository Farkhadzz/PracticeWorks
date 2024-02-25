using AutozMVC.Data.Database;
using AutozMVC.Data.Repositories.Base;
using AutozMVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

public class CarRepository : ICarRepository
{
    private readonly AppDbContext appDbContext;

    public CarRepository(AppDbContext appDbContext)
    {
        this.appDbContext = appDbContext;
    }

    public IEnumerable<Car> AllCars => appDbContext.Car.ToList();
    public IEnumerable<Car> GetFavoriteCars => appDbContext.Car.Where(c => c.IsFavorite).ToList();

    public void AddCar(Car car)
    {
        if (car is null)
        {
            throw new ArgumentNullException();
        }
        appDbContext.Car.Add(car);
        appDbContext.SaveChanges();
    }

        public Car GetObjectCar(int carId)
    {
        return appDbContext.Car.FirstOrDefault(c => c.Id == carId);
    }
}
