using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LegendSamples.Pages
{
    public class ReverseModel : PageModel
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
