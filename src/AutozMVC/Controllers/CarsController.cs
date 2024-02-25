using AutozMVC.Data.Repositories.Base;
using AutozMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutozMVC.Controllers;

public class CarsController : Controller
{

    private readonly ICarRepository _carRepository;
    public CarsController(ICarRepository _carRepository)
    {
        this._carRepository = _carRepository;
    }

    [HttpGet]
    public IActionResult ShowCar()
    {
        var allCars = _carRepository.AllCars.ToList();
        return View(allCars);
    }

    [HttpGet]
    public IActionResult AddCar()
    {
        return View();
    }


    [HttpPost]
    public IActionResult AddCar([FromForm] Car newCar)
    {
        _carRepository.AddCar(newCar);
        return RedirectToAction("ShowCar");
    }

    public IActionResult CarDetails(int id)
    {
        var car = _carRepository.GetObjectCar(id);
        return PartialView("_CarDetailsPartial", car);
    }

}