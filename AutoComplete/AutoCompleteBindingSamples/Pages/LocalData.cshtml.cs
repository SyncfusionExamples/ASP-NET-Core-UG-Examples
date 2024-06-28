using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AutoCompleteBindingSamples.Pages;

public class LocalData : PageModel
{
    public void OnGet()
    {
        
    }
}
public class RecordData
{
    public string ID { get; set; }
    public string Text { get; set; }
    public List<RecordData> RecordList { set; get; }
    public List<RecordData> RecordModelList()
    {
        return Enumerable.Range(1, 150).Select(i => new RecordData()
        {
            ID = i.ToString(),
            Text = "Item " + i,
        }).ToList();
    }
}