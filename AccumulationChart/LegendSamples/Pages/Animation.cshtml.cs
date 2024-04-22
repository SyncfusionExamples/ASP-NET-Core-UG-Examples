using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LegendSamples.Pages
{
    public class AnimationModel : PageModel
    {
        public void OnGet()
        {
        }
        public class GroupingChartData
        {
            public string xValue;
            public double yValue;
            public string text;
        }
    }
}
