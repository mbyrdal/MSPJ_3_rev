using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuperHeroAPI_DotNet8.Data;
using SuperHeroAPI_DotNet8.Entities;

namespace SuperHeroAPI_DotNet8.Controllers
{

    /// <summary>
    /// A 'fat' controller, which means it stores all logic within itself. 
    /// Usually you'd want to inject a repository or a service that contains all the logic.
    /// The controller would then just forward requests and responses between a client and a server.
    /// </summary>

    // Route can be found in Properties->launchSettings.json (localhost:7145/ ...)
    // In this project, [controller] specifies the name of the controller in question -> SuperHeroController
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        // Inject our data context DataContext
        private readonly DataContext _context;
        public SuperHeroController(DataContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Async HTTP GET method that returns a list of all SuperHeroes.
        /// </summary>
        /// <returns>A list of all SuperHero objects in a list.</returns>
        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllHeroes()
        {
            // Access our SuperHeroes table...
            var heroes = await _context.SuperHeroes.ToListAsync();
            return Ok(heroes);

            /*
             * OLD VERSION
            var heroes = new List<SuperHero>
            {
                new SuperHero
                {
                    Id = 1,
                    Name = "Spiderman",
                    FirstName = "Peter",
                    LastName = "Parker",
                    Place = "New York City"
                }
            };
            */

            // Returns status code 200 OK if successful
        }

        /// <summary>
        /// Returns a single SuperHero based on their ID. Route is specified in the HttpGet header.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A superHero object with a unique ID.</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHero>> GetHero(int id)
        {
            // Finds hero based on ID.
            var hero = await _context.SuperHeroes.FindAsync(id);

            if(hero == null)
            {
                return NotFound("Hero not found."); // Returns status code 404 not found, bad request would be status code 403.
            }

            return Ok(hero);
        }

        /// <summary>
        /// Adds a new SuperHero to the Database using HTTP POST. Input parameter is a SuperHero class with its specifications.<br/>
        /// Best practice: use a DTO (Data Transfer Object) as input, where only {Name, FirstName, LastName, Place} properties are necessary.<br/>
        /// IDs can be generated automatically with another request, which also ensures correct indexing on the SuperHero Database.
        /// </summary>
        /// <param name="hero">The hero object details</param>
        /// <returns>Adds a new SuperHero to the DB.</returns>
        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero hero)
        {
            // This code adds the SuperHero to the Database. 
            // However, this will NOT save the changes -> Call .SaveChangesAsync().
            _context.SuperHeroes.Add(hero);
            await _context.SaveChangesAsync();

            return Ok(await _context.SuperHeroes.ToListAsync());
        }

        /// <summary>
        /// Updates an existing hero based on input parameters.
        /// </summary>
        /// <param name="hero">SuperHero class object</param>
        /// <returns>Updated SuperHero instance in the Database.</returns>
        [HttpPut]
        public async Task<ActionResult<List<SuperHero>>> UpdateHero(SuperHero updatedHero)
        {
            var dbHero = await _context.SuperHeroes.FindAsync(updatedHero.Id);
            if(dbHero == null)
            {
                return NotFound("Hero not found.");
            }

            dbHero.Name = updatedHero.Name;
            dbHero.FirstName = updatedHero.FirstName;
            dbHero.LastName = updatedHero.LastName;
            dbHero.Place = updatedHero.Place;

            await _context.SaveChangesAsync();

            return Ok(await _context.SuperHeroes.ToListAsync());
        }

        /// <summary>
        /// Deletes a SuperHero based on their ID.
        /// </summary>
        /// <param name="id">Hero ID as integer.</param>
        /// <returns>Updated database where target SuperHero class object is deleted.</returns>
        [HttpDelete]
        public async Task<ActionResult<List<SuperHero>>> DeleteHero(int id)
        {
            var dbHero = await _context.SuperHeroes.FindAsync(id);

            // Alternative notation for NULL instance
            if(dbHero is null)
            {
                return NotFound("Hero not found.");
            }

            _context.SuperHeroes.Remove(dbHero);
            await _context.SaveChangesAsync();

            return Ok(await _context.SuperHeroes.ToListAsync());
        }
    }
}
