using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GroupPointAnnotationSample.Pages
{
    public class CustomEmptyModel : PageModel
    {
        public void OnGet()
        {
        }
        public class EmptyPointsChartData
        {
            public string xValue;
            public Nullable<double> yValue;
        }
    }
}
