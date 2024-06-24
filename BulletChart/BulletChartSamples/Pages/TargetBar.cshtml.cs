using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulletChartSamples.Pages;

public class TargetBar : PageModel
{
    public void OnGet()
    {
        
    }
}
public class TargetBarData
{           
    public double value;
    public double target;
}