﻿using WordQuiz.Models;

namespace WordQuiz.Data.Repositories
{
    public interface IWordStaticRepository
    {
        void Add(WordStatistic entity);
        void Delete(string id);
        IEnumerable<WordStatistic> GetAll();
        WordStatistic GetById(string id);
        WordStatistic Update(WordStatistic entity);
    }
}