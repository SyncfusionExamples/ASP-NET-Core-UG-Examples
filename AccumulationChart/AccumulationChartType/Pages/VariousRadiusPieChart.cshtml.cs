using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AccumulationChartType.Pages
{
    public class VariousRadiusPieChartModel : PageModel
    {
        public void OnGet()
        {
        }
        public class PieRadiusChartData
        {
            public string xValue;
            public double yValue;
            public string r;
        }
    }
}
