using EntityFramework_Clase3.Models;
using EntityFramework_Clase3.Services;
using Microsoft.AspNetCore.Mvc;

namespace EntityFramework_Clase3.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsuarioController : ControllerBase
{
    private readonly IUsuarioRepository _repository;

    public UsuarioController(IUsuarioRepository repository)
    {
        _repository = repository;
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var student = _repository.GetById(id);
        if (student == null) return NotFound();
        return Ok(student);
    }

    [HttpPost]
    public IActionResult Create(Usuario student)
    {
        _repository.Add(student);
        _repository.Save();
        return CreatedAtAction(nameof(GetById), new { id = student.ID }, student);
    }
}