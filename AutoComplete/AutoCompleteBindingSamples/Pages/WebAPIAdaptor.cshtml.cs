using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AutoCompleteBindingSamples.Pages;

[Route("api/[controller]")]
public class WebAPIAdaptor : PageModel
{
    public List<string> game = new List<string>();
    [HttpGet]
    public List<string> Get()
    {
        game.Add("Badminton");
        game.Add("Basketball");
        game.Add("Cricket");
        game.Add("Golf");
        game.Add("Gymnastics");
        game.Add("Tennis");
        game.Add("Hockey");
        return game;
    }
    public void OnGet()
    {
        
    }
}