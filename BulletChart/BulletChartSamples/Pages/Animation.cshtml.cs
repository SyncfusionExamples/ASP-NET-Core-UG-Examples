using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulletChartSamples.Pages;

public class Animation : PageModel
{
    public void OnGet()
    {
        
    }
}
public class AnimationData
{           
    public double value;
    public double target;
}