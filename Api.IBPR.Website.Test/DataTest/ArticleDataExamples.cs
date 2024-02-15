using Api.IBPR.Website.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.IBPR.Website.Test.DataTest
{
    public static class ArticleDataExamples
    {
        public static Article ArticleById(int id)
        {
            string text = "this is a text example ";
            return new Article()
            {
                Id = id,
                Author = "Rick Warren",
                CreateAt = DateTime.Now,
                Text = Encoding.UTF8.GetBytes(text),
                Title = "A Life with porpuse",
                IdImage = 2,
                IdVerse = 3,
                IdComment = 123
            };
        }
    }
}
