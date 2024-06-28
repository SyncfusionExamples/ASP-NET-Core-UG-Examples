using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GroupPointAnnotationSample.Pages
{
    public class AlignmentModel : PageModel
    {
        public void OnGet()
        {
        }
        public class PieChartData
        {
            public string x;
            public double y;
        }
    }
}
