using System;
using System.Collections.Generic;
using CorebitzApi.Entities;

namespace CorebitzApi.Services
{
    public class InMemoryRepository : IRepository
    {

        private List<Genre> genres;

        public InMemoryRepository()
        {
            genres = new List<Genre>()
            {
                new Genre{Id=1, Name="Comedy"},
                new Genre{Id=2, Name="Action"},
            };
        }

        public async Task<List<Genre>> GetAllGenre()
        {
            await Task.Delay(1000);
            return genres;
        }

        public Genre GetGenreById(int id)
        {
            return genres.FirstOrDefault(x => x.Id == id);
        }
    }
}


