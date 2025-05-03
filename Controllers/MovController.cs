using Microsoft.AspNetCore.Mvc;
using mod10_103022300001.Auth;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace mod10_103022300001.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovController : ControllerBase
    {
        private static List<Movie> MovieList = new List<Movie>
        {
            new Movie {Title = "The Shawshank Redemption", Director = "Frank Darabont", Stars = new List<string>{"9.3"}, Description = "A banker convicted of uxoricide forms a friendship over a quarter century with a hardened convict, while maintaining his innocence and trying to remain hopeful through simple compassion."},
            new Movie {Title = "The Godfather", Director = "Francis Ford Coppola", Stars = new List<string>{"9.2"} , Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son."},
            new Movie {Title = "The Dark Night", Director = "Christopher Nolan", Stars = new List<string>{"9.0"} , Description = "When a menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman, James Gordon and Harvey Dent must work together to put an end to the madness."}
        };
        // GET: api/<MovController>
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return MovieList;
        }

        // GET api/<MovController>/5
        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            return MovieList[id];
        }

        // POST api/<MovController>
        [HttpPost]
        public void Post([FromBody] Movie value)
        {
            MovieList.Add(value);
        }

        // PUT api/<MovController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MovController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            MovieList.Remove(MovieList[id]);
        }
    }
}
