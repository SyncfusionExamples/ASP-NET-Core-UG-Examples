using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TemplateUGSample.Pages
{
    public class GroupingModel : PageModel
    {
        public void OnGet()
        {
        }
    }
    public class Vegetables
    {
        public string Vegetable { get; set; }
        public string Category { get; set; }
        public string Id { get; set; }
    }
}
