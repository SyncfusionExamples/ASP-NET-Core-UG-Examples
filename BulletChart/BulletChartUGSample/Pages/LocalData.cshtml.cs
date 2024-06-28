using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulletChartUGSample.Pages;

public class LocalData : PageModel
{
    public void OnGet()
    {
        
    }
}
public class LocalBulletData
{
    public double value;
    public double comparativeMeasureValue;
    public string category;
}