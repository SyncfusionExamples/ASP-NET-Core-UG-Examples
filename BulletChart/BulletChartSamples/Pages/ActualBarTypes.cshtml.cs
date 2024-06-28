using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulletChartSamples.Pages;

public class ActualBarTypes : PageModel
{
    public void OnGet()
    {
        
    }
}
public class ActualBarTypeData
{           
    public double value;
    public double target;
}