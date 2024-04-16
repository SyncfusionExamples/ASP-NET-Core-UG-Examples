using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PyramidFunnelTypeSample.Pages
{
    public class FunnelSmartLabelModel : PageModel
    {
        public void OnGet()
        {
        }
        public class FunnelData
        {
            public string xValue;
            public double yValue;
            public string text;
        }
    }
}
