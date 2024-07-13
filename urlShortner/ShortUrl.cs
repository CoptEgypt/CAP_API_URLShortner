namespace urlShortner;
using System;


public class ShortUrl
{
    //representation of a long URL
    public string? URL { get; set; }

    // public test test=new test();

    //represent who created the link
    public string? CreatedBy { get; set; }

    //represents the number of times the short URL was used
    public int Hits { get; set; }

    // //representation of a short URL
    public string? UrlID { get; internal set; }
    public int AddHits() { return 1;}
    // public int gethits(){return this.test.gethit();}

    

}
    