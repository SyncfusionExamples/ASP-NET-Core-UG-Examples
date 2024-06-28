using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AutoCompleteBindingSamples.Pages;

public class ArrayOfComplex : PageModel
{ 
    public void OnGet()
    {
        
    }
}
public class Code
{
    public string Id { get; set; }
}

public class Country
{
    public string CountryId { get; set; }
}
public class Complex
{
    public Country Country { get; set; }
    public Code Code { get; set; }
}