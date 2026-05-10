namespace BlazingBlog.Domain.Articles;

public interface IArticleRepository
{
    Task<List<Article>> GetAllArticlesAsync();
    Task<Article?> CreateArticleAsync(Article article);
    Task<Article> GetArticleByIdAsync(int id);
    Task<Article?> UpdateArticleAsync(Article article);
    Task<bool> DeleteArticleAsync(int id);
}