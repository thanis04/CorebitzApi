using System;
using System.Collections.Generic;
using CorebitzApi.Entities;


namespace CorebitzApi.Services
{
    public interface IRepository
    {
        Task<List<Genre>> GetAllGenre();
        Genre GetGenreById(int id);
    }
}

