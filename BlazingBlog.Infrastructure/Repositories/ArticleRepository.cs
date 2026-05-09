using BlazingBlog.Domain.Articles;
using Microsoft.EntityFrameworkCore;

namespace BlazingBlog.Infrastructure.Repositories;

public class ArticleRepository : IArticleRepository
{
    private readonly ApplicationDbContext _context;

    public ArticleRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Article>> GetAllArticlesAsync()
    {
        return await _context.Articles.ToListAsync();
    }

    public async Task<Article> CreateArticleAsync(Article article)
    {
        _context.Add(article);
        await _context.SaveChangesAsync();
        return article;
    }
}