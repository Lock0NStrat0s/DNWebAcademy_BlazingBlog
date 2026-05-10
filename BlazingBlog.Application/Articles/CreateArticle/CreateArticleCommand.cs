using BlazingBlog.Application.Abstractions.RequestHandling;
using BlazingBlog.Domain.Articles;
using MediatR;

namespace BlazingBlog.Application.Articles.CreateArticle;

public class CreateArticleCommand : ICommand<ArticleResponse>
{
    public required string Title { get; set; }
    public string? Content { get; set; }
    public DateTime DatePublished { get; set; } =  DateTime.UtcNow;
    public bool IsPublished { get; set; } = false;
}