using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SchoolNumbers.Models;

namespace SchoolNumbers.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }


    
    public IActionResult Index(int num, int denum)
    {
        Fraction fraction = new Fraction(num, denum);
        ViewData["item_1"] = (new Fraction(3,0)).ToString();
        ViewData["item_2"] = Fraction.gen_fraction().ToString();
        ViewData["item_3"] = Fraction.gen_fraction().ToString();
        ViewData["item_4"] = Fraction.gen_fraction().ToString();
        ViewData["item_5"] = Fraction.gen_fraction().ToString();

        //Console.WriteLine(num);
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [Route("get_input")]
    [HttpPost]
    public IActionResult GetInput()
    {
        Console.WriteLine("test1");
        int it = 1;
        foreach (var i in Request.Form){
            Fraction.TryParse(i.Key, out Fraction fr);
            Answer ans = new Answer(fr, i.Value);

            ViewData[$"fraction_{it}"] = ans.Fraction;
            ViewData[$"ans_{it}"] = ans.Fraction.Text();
            ViewData[$"ans_us_{it}"] = ans.Input;
            // надо комментарий
            ViewData[$"flag_{it}"] = ans.IsCoreect ? "Correct" : "Incorrect";
            it++;
        }
        return View();
    }
}
