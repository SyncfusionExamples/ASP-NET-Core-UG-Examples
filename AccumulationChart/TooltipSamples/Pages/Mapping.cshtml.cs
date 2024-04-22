using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TooltipSamples.Pages
{
    public class MappingModel : PageModel
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
