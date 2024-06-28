using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulletChartSamples.Pages;

public class CustomDataLabel : PageModel
{
    public void OnGet()
    {
        
    }
}
public class CustomData
{           
    public double value;
    public double comparativeMeasureValue;
    public string category;
}