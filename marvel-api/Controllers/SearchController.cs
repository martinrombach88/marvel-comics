using Microsoft.AspNetCore.Mvc;

namespace marvel_api.Controllers;

[ApiController]
[Route("[controller]")]
public class SearchController : Controller
{

    [HttpGet("/'{searchTerm}'")]
    public string SearchTitles(string searchTerm)
    {
        string result = searchTerm;
        return result;
    }


}
