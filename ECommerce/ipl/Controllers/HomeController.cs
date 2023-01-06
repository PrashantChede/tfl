using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ipl.Models;
using System.Collections.Generic;
using HR;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ipl.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Login()
    {
        return View();
    }


      List<Employee> employees= new List<Employee>();
    string fileName=@"E:\CDAC_2022_sep\.NET\Practice\ccc.json";

     public IActionResult Validate(string email, string password)
    {

        var data=System.IO.File.ReadAllText(fileName);
        List<Employee> newEmp=JsonSerializer.Deserialize<List<Employee>>(data);
        foreach(Employee e in newEmp)
        {
            if(e.Email==email  && e.Password==password)
            {
                return Redirect("MostWelcome");
            }
        }


        return View();
    }


    

    public IActionResult Add(string firstname,string email,string password)
    {
        string readData=System.IO.File.ReadAllText(fileName);
        List<Employee> newList=JsonSerializer.Deserialize<List<Employee>>(readData);
        employees=newList;
    
        Employee emp=new Employee(){FirstName=firstname,Email=email,Password=password};
        employees.Add(emp);
       var jsonData=JsonSerializer.Serialize<List<Employee>>(employees);
        System.IO.File.WriteAllText(fileName,jsonData);

    return Redirect("Welcome");

        return View();
    }



    public IActionResult Register()
    {
        return View();
    }

    public IActionResult Welcome()
    {
        return View();
    }

    public IActionResult MostWelcome()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
