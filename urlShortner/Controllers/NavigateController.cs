using Microsoft.AspNetCore.Mvc;

namespace urlShortner.Controllers;

using System.Reflection.Metadata.Ecma335;
using urlShortner;

[ApiController]
[Route("[controller]")]
public class Navigate : ControllerBase
{
    // private static readonly string[] Summaries = new[]
    // {
    //     "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    // };

    private readonly ILogger<Navigate> _logger;

    public Navigate(ILogger<Navigate> logger)
    {
        _logger = logger;
    }


    [HttpGet("navigate/{id}")]
    public IActionResult NavigateRedirection(string id){
       // TODO: return
       return Redirect("http://google.com");
       
    }
}

    
    
         
    
    

