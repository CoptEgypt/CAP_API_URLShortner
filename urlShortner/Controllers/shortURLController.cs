using System.Text.Json;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UrlShortener.Models;
using UrlShortner.Models;

namespace UrlShortner.Controllers;

[Authorize(AuthenticationSchemes = $"{JwtBearerDefaults.AuthenticationScheme},BasicAuthentication")]
[ApiController]
[Route("[controller]")]
public class ShortUrlsController : ControllerBase
{
    private readonly UrlShortenerContext _context;
    public ShortUrlsController(UrlShortenerContext context)
    {
        _context = context;
    }
    
    [HttpPut("{urlID}")]
    public string CreateShortUrl(string urlID, [FromBody] JsonElement body)
    {
        var domainName = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}";

        Console.WriteLine($"request to create: {urlID}, {body.GetProperty("url")}");
        Url url = new()
        {
            OriginalUrl = body.GetProperty("url").ToString(),
            ShortenedUrl = $"{domainName}/navigate/{Guid.NewGuid()}",
            UrlId = urlID,
            UserId = 0
        };

        _context.Urls.Add(url);
        _context.SaveChanges();

        return url.ShortenedUrl;
    }

    [HttpDelete("{urlID}")]
    public string DeleteShortUrl(string urlID)
    {
        Console.WriteLine($"request to delete: {urlID}");

        var url = _context.Urls.FirstOrDefault(u => string.Equals(u.UrlId, urlID));
        if (url != null)
        {
            _context.Remove(url);
            _context.SaveChanges();
            return "deleted!";
        }

        return "not found!";
    }

    [HttpGet("{urlID}")]
    public Url GetShortUrl(string urlID)
    {
        var url = _context.Urls.SingleOrDefault(u => u.UrlId == urlID);

        if (url == null)
        {
            return null;
        }

        return url;
    }

    [HttpGet]
    public List<Url> List()
    {
        return _context.Urls.ToList();
    }

    [HttpGet("{urlID}/hits")]
    public int Hits([FromRoute] Url url)
    {
        // TODO: return
        return 3;
    }

    [HttpGet]
    [Route("navigate/{url}")]
    public IActionResult NavigateRedirection(string url)
    {
        // TODO: return
        return Redirect("http://google.com");
    }
}
    // [allowanonymous]
    // [HttpPost]
    // public IActionResult generateHashes(){

    //     foreach(var User in DataMock.Users){
    //         User.Password = HashedPassword(User.Password, User.PasswordSalt);
    //         return User.Password;
    //     }
    // }



    
    
         
    
    

