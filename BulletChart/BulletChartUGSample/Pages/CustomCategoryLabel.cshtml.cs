using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulletChartUGSample.Pages;

public class CustomCategoryLabel : PageModel
{
    public void OnGet()
    {
        
    }
}
public class CustomCategory
{           
    public double value;
    public double target;
    public string category;
}