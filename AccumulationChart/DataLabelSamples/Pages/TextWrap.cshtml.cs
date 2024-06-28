using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DataLabelSamples.Pages
{
    public class TextWrapModel : PageModel
    {
        public void OnGet()
        {
        }
        public class PieChartData
        {
            public string x;
            public double y;
            public string text;
            public string tooltipMappingName;
        }
    }
}
