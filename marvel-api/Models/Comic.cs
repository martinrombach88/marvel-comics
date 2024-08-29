namespace marvel_api.Models;

public partial class Comic
{
    //fields make the db -> can you adapt this?
    public string comic_name { get; set; } = "";
    public string active_years { get; set; } = "";
    //for a non nullable type, it allows the variable to be null
    public DateTime? publish_date { get; set; }
    public string issue_description { get; set; } = "";
    public string penciler { get; set; } = "";
    public string writer { get; set; } = "";
    public string cover_artist { get; set; } = "";
    public string imprint { get; set; } = "";
    public string format { get; set; } = "";
    public string rating { get; set; } = "";
    public string price { get; set; } = "";


}