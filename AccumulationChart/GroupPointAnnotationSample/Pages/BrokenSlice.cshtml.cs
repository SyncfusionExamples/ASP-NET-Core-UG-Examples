using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GroupPointAnnotationSample.Pages
{
    public class BrokenSliceModel : PageModel
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
