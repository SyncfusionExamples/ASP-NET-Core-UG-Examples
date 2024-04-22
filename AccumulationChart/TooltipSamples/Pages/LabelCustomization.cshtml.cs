using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TooltipSamples.Pages
{
    public class LabelCustomizationModel : PageModel
    {
        public void OnGet()
        {
        }
        public class PieChartData
        {
            public string x;
            public double y;
            public string text;
        }
    }
}
