using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ComboBoxHowToSample.Pages
{
    public class CascadingComboBoxModel : PageModel
    {
        public void OnGet()
        {
        }
    }
    public class State
    {
        public string StateName { get; set; }
        public string CountryId { get; set; }
        public string StateId { get; set; }
    }
    public class Country
    {
        public string CountryName { get; set; }
        public string CountryId { get; set; }
    }
    public class Cities
    {
        public string CityName { get; set; }
        public string StateId { get; set; }
        public int CityId { get; set; }
    }
}
