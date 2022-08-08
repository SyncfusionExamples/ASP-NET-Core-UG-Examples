using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarouselUGSample.Pages
{
    public class PopulateItemsModel : PageModel
    {
        public void OnGet()
        {
        }
    }
    public class CarouselDataBinding
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
