using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ipl.Models;
using System.Collections.Generic;
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

     public IActionResult Register()
    {
        return View();
    }




     public IActionResult Validate(string email,string password)
    {
        if(email=="abc@gmail.com" &&  password=="abc@123")
        {
            return Redirect ("Welcome");
        }

        return View();
    }

     List<Object> players= new List<Object>();
   
     string fileName=@"E:\chaitanya_prashant\.Net\lab_dotnet\Day8\ECommerce\ppp.json";

     public IActionResult Add(string firstname,string email,string password)
    {

        try{
            string readData = System.IO.File.ReadAllText(fileName);
            List<Object> jsonData = JsonSerializer.Deserialize<List<Object>>(readData);
            players=jsonData;
            players.Add(new { FirstName=firstname,Email=email,Password=password});
            var produtsJson=JsonSerializer.Serialize<List<Object>>(players);
            
            
            //Serialize all Flowers into json file

        System.IO.File.WriteAllText(fileName,produtsJson);
        
   
    }
   catch(Exception exp){
    
    }

    return Redirect ("Welcome");



 if(email=="abc@gmail.com" &&  password=="abc@123")
        {
            return Redirect ("Welcome");
        }






        return View();
    }

     public IActionResult Welcome()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
