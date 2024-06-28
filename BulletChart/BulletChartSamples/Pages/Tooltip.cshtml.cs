using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulletChartSamples.Pages;

public class Tooltip : PageModel
{
    public void OnGet()
    {
        
    }
}
public class TooltipData
{           
    public double value;
    public double comparativeMeasureValue;
    public string category;
}