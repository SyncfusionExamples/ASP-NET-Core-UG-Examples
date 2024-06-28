using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AutoCompleteBindingSamples.Pages;

public class PrimitiveDataType : PageModel
{
    public void OnGet()
    {
        
    }
}
public class Records
{
    public string ID { get; set; }
    public string Text { get; set; }
    public List<Records> RecordList { set; get; }
    public List<Records> RecordModelList()
    {
        return Enumerable.Range(1, 150).Select(i => new Records()
        {
            ID = i.ToString(),
            Text = "Item " + i,
        }).ToList();
    }
}