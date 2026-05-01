using BlazingBlog.Domain.Articles;

namespace BlazingBlog.Application.Articles;

public interface IArticleService
{
    List<Article> GetAllArticles();
    
}