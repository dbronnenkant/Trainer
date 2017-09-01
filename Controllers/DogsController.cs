using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trainer.Data;

namespace Trainer.Controllers
{
    [Produces("application/json")]
    [Route("api/Dogs")]
    public class DogsController : Controller
    {
        private readonly DiagonAlleyContext _context;

        public DogsController(DiagonAlleyContext context)
        {
            _context = context;
        }

        // GET: api/Dogs
        [HttpGet]
        public IEnumerable<Dog> GetDog()
        {
            return _context.Dog;
        }

        // GET: api/Dogs/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDog([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dog = await _context.Dog.SingleOrDefaultAsync(m => m.DogId == id);

            if (dog == null)
            {
                return NotFound();
            }

            return Ok(dog);
        }

        // PUT: api/Dogs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDog([FromRoute] int id, [FromBody] Dog dog)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != dog.DogId)
            {
                return BadRequest();
            }

            _context.Entry(dog).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DogExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Dogs
        [HttpPost]
        public async Task<IActionResult> PostDog([FromBody] Dog dog)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Dog.Add(dog);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDog", new { id = dog.DogId }, dog);
        }

        // DELETE: api/Dogs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDog([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dog = await _context.Dog.SingleOrDefaultAsync(m => m.DogId == id);
            if (dog == null)
            {
                return NotFound();
            }

            _context.Dog.Remove(dog);
            await _context.SaveChangesAsync();

            return Ok(dog);
        }

        private bool DogExists(int id)
        {
            return _context.Dog.Any(e => e.DogId == id);
        }
    }
}