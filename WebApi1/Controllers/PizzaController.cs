using WebApi1.Models;
using WebApi1.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi1.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase {
    public PizzaController () {

    }
    // GET all
    [HttpGet]
    public ActionResult<List<Pizza>> GetAll() =>
        PizzaService.GetAll();

    // GET by Id
    [HttpGet("{Id}")]
    public ActionResult<Pizza> Get(int Id){
        var pizza = PizzaService.Get(Id);
        if (pizza == null) {
            return NotFound();
        }
        return pizza;
    }

    // POST
    [HttpPost]
    public IActionResult Create(Pizza pizza) {
        PizzaService.Add(pizza);
        return CreatedAtAction(nameof(Get), new { Id = pizza.Id }, pizza);
    }

    // PUT
    [HttpPut("{Id}")]
    public IActionResult Update(int Id, Pizza pizza) {
        if (Id != pizza.Id) {
            return BadRequest();
        }
        var existingPizza = PizzaService.Get(Id);
        if (existingPizza == null) {
            return NotFound();
        }
        PizzaService.Update(pizza);
        return NoContent();
    }

    // DELETE
    [HttpDelete("{Id}")]
    public IActionResult Delete(int Id) {
        var pizza = PizzaService.Get(Id);
        if (pizza == null) {
            return NotFound();
        }
        PizzaService.Delete(Id);
        return NoContent();
    }
}
