using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ComboBoxHowToSample.Pages
{
    public class ItemwithIconsModel : PageModel
    {
        public void OnGet()
        {
        }
    }
    public class SocialMedia
    {
        public string Class { get; set; }
        public string SocialMediaName { get; set; }
        public string Id { get; set; }
    }
}
