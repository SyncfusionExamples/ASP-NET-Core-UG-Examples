using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AppBarUGSamples.Pages;

public class DesignWithSidebar : PageModel
{
    public void OnGet()
    {
        
    }
}
public class TreeDatas
{
    public string nodeId { get; set; }
    public string nodeText { get; set; }
    public bool hasChild { get; set; }
    public string pid { get; set; }
}