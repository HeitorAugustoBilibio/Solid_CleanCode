using Microsoft.AspNetCore.Mvc;
using Service.Dtos;
using Service.Interfaces;
namespace AppContatos.Controllers;


[Route("api/[controller]")]
[ApiController]
public class ContatoController : ControllerBase
{
    private readonly IContatoService _contatoService;

    public ContatoController(IContatoService contatoService)
    {
        _contatoService = contatoService;
    }

    [HttpGet]
    [Route("GetAll")]
    public async Task<IActionResult> Getall()
    {
        return new JsonResult(await _contatoService.GetAll());
    }

    [HttpPost]
    [Route("InsertContact")]
    public async Task<IActionResult> Insert([FromBody] ContatosDTo model)
    {
        return new JsonResult(await _contatoService.Insert(model));
    }
}
