namespace AutozMVC.Data.Mocks;
using AutozMVC.Data.Interfaces;
using AutozMVC.Models;

public class CategoryMock : IAllCategories {
    public IEnumerable<Category> AllCategories {
        get {
            return new List<Category> {
                new Category { CategoryName = "Электромобили", Description = "Современный вид транспорта" },
                new Category { CategoryName = "Классические автомобили", Description = "Машины с двигетелем внутренного згорания" },
            };
        }
    }
}