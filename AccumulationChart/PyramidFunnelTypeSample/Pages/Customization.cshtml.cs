using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PyramidFunnelTypeSample.Pages
{
    public class CustomizationModel : PageModel
    {
        public void OnGet()
        {
        }
        public class PyramidChartData
        {
            public string xValue;
            public double yValue;
        }
    }
}
