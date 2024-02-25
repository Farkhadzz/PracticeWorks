using AutozMVC.Data.Interfaces;
using AutozMVC.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AutozMVC.Controllers;

public class CarsController : Controller {

    private readonly IAllCars _allCars;
    private readonly IAllCategories _allCategories;

    public CarsController(IAllCars allCars, IAllCategories allCategories)
    {
        this._allCars = allCars;
        this._allCategories = allCategories;
    }

    public IActionResult List() {
        var obj = new CarsListViewModel();
        obj.AllCars = _allCars.AllCars;
        obj.carCategory = "Autos";

        return View(obj);
    }
}