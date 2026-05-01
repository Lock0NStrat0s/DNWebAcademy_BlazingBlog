using BlazingBlog.Domain.Articles;

namespace BlazingBlog.Application.Articles;

public class ArticleService : IArticleService
{
    public List<Article> GetAllArticles()
    {
        return new List<Article>
        {
            new Article
            {
                Id = 1,
                Title = "My first article",
                Content = "This is my first article"
            },
            new Article
            {
                Id = 2,
                Title = "My second article",
                Content = "This is my second article"
            }
        };
    }
}