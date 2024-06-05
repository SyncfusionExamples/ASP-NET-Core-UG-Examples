using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AppBarUGSamples.Pages
{
    public class MenuModel : PageModel
    {
        public void OnGet()
        {
        }
        public class MenuItem
        {
            public string Text { get; set; }
            public List<MenuItem> Items { get; set; }
        }
    }
}
