using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulletChartUGSample.Pages;

public class CategoryLabel : PageModel
{
    public void OnGet()
    {
        
    }
}
public class Category
{           
    public double value;
    public double target;
    public string category;
}