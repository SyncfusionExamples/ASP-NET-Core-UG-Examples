using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AutoCompleteBindingSamples.Pages;

public class BindRemoteData : PageModel
{
    public void OnGet()
    {
        
    }
}
public class BindingRecord
{
    public string ID { get; set; }
    public string Text { get; set; }
    public List<BindingRecord> RecordList { set; get; }
    public List<BindingRecord> RecordModelList()
    {
        return Enumerable.Range(1, 150).Select(i => new BindingRecord()
        {
            ID = i.ToString(),
            Text = "Item " + i,
        }).ToList();
    }
}