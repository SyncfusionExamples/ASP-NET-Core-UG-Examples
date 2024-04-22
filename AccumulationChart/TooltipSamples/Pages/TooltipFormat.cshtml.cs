using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TooltipSamples.Pages
{
    public class TooltipFormatModel : PageModel
    {
        public void OnGet()
        {
        }
        public class PieChartData
        {
            public string xValue;
            public double yValue;
        }
    }
}
