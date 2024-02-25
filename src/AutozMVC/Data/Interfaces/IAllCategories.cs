namespace AutozMVC.Data.Interfaces;
using AutozMVC.Models;

public interface IAllCategories {
    IEnumerable<Category> AllCategories { get; }
}