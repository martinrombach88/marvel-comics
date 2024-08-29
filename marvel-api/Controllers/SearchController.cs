using Microsoft.AspNetCore.Mvc;
using marvel_api.Models;
using marvel_api.Data;
using AutoMapper;

namespace marvel_api.Controllers;

[ApiController]
[Route("[controller]")]
public class SearchController : ControllerBase
{
    DataContext _entityFramework;
    IMapper _mapper;

    public SearchController(IConfiguration config)
    {
        _entityFramework = new DataContext(config);
        _mapper = new Mapper(new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Comic, Comic>().ReverseMap();
        }));
    }

    [HttpGet("/")]
    public IEnumerable<Comic> GetComics()
    {
        IEnumerable<Comic> comics = _entityFramework.Comics.ToList<Comic>();
        return comics;
    }


}
