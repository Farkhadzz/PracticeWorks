namespace TrafficPolice.Controllers;

using Microsoft.AspNetCore.Mvc;
using TrafficPolice.Interfaces;


public class FinesController : Controller {

    private readonly IAllFines _allFines;
    public FinesController(IAllFines allFines) {
        _allFines = allFines;
    }

    public IActionResult List () {
        var fines = _allFines.Fines;

        return View(fines);
    }
}