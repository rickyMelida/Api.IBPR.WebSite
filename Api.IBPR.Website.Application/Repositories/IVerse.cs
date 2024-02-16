﻿using Api.IBPR.Website.Domain.Entities;

namespace Api.IBPR.Website.Application.Repositories
{
    public interface IVerse
    {
        Task<List<Verse>> GetVerses();
        Task<Verse> GetVerse(int id);
        Task SetVerse(Verse verse);
    }
}