using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulletChartSamples.Pages;

public class DataLabel : PageModel
{
    public void OnGet()
    {
        
    }
}
public class Data
{           
    public double value;
    public double comparativeMeasureValue;
    public string category;
}