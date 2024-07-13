using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace urlShortner.Controllers;

[Authorize(AuthenticationSchemes = $"{JwtBearerDefaults.AuthenticationScheme},BasicAuthentication")]
[ApiController]
[Route("[controller]")]
public class shortURLsController : ControllerBase
{
    // private static readonly string[] Summaries = new[]
    // {
    //     "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    // };
    // urlShortnerContext _context;

    private readonly ILogger<shortURLsController> _logger;

    // public shortURLsController(ILogger<shortURLsController> logger, urlShortnerContext context)
    
    public shortURLsController(ILogger<shortURLsController> logger)
    {
        _logger = logger;
        // _context = context;
    }

    [HttpGet("{urlID}")]
    public ShortUrl Get([FromRoute] string urlID)
    {
// TODO: return
        return new ShortUrl()
        {
            UrlID = urlID,

        };
    }

    [HttpPut("{urlID}")]
    public ShortUrl Put([FromRoute] string urlID, [FromBody] ShortUrl shortUrl)
    {
       
        return new ShortUrl() { 
            Hits=shortUrl.AddHits(),
            UrlID = urlID,
            URL = shortUrl.URL
             
        };
    }

    [HttpDelete("{urlID}")]
    public ShortUrl Delete([FromRoute] string urlID) {
            
        return new ShortUrl() {
                UrlID=null,
                URL=null
                
            };

         }

    [HttpGet("{urlID}/hits")]
    
    public int Hits([FromRoute] ShortUrl url){
       // TODO: return
        return 3;
    }
    [HttpGet]
    [Route("navigate/{url}")]
    public IActionResult NavigateRedirection(string url){
       // TODO: return
       return Redirect("http://google.com");
       
    }
    // [allowanonymous]
    // [HttpPost]
    // public IActionResult generateHashes(){

    //     foreach(var User in DataMock.Users){
    //         User.Password = HashedPassword(User.Password, User.PasswordSalt);
    //         return User.Password;
    //     }
    // }
}


    
    
         
    
    

