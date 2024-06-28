using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AutoCompleteBindingSamples.Pages;

public class ObjectDataType : PageModel
{
    public void OnGet()
    {
        
    }
}
public class Record
{
    public string ID { get; set; }
    public string Text { get; set; }
    public List<Record> RecordList { set; get; }
    public List<Record> RecordModelList()
    {
        return Enumerable.Range(1, 150).Select(i => new Record()
        {
            ID = i.ToString(),
            Text = "Item " + i,
        }).ToList();
    }
}