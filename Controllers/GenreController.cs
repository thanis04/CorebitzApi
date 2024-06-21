using System;
using CorebitzApi.Services;
using CorebitzApi.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CorebitzApi.Controllers
{
    [Route("api/geres")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IRepository repository;

        public GenreController(IRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        [HttpGet("list")]
        [HttpGet("/algenres")]
        public async Task<ActionResult<List<Genre>>> Get()
        {
            return await repository.GetAllGenre();
        }

        [HttpGet("{id:int}/{param2=felipe}")]
        public ActionResult<Genre> Get(int id, string param2) 
        {

            var genre = repository.GetGenreById(id);
            if (genre == null)
            {
                return NotFound();
            }
            return genre;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Genre genre) 
        {
            return NotFound();
        }

        [HttpPut]
        public ActionResult Put([FromBody] Genre genre) 
        {
            return NotFound();
        }

        [HttpDelete]
        public ActionResult Delete() 
        {
            return NotFound();
        }
    }
}

