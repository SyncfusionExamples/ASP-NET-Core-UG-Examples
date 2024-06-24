using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulletChartUGSample.Pages;

public class OpposedPosition : PageModel
{
    public void OnGet()
    {
        
    }
}
public class OpposedPositionData
{           
    public double value;
    public double target;
}