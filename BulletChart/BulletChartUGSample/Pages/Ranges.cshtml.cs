using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulletChartUGSample.Pages;

public class Ranges : PageModel
{
    public void OnGet()
    {
        
    }
}
public class Range
{           
    public double value;
    public double target;
    public string category;
}