using MediatR;

namespace BlazingBlog.Application.Articles.UpdateArticle;

public class UpdateArticleCommand : ICommand<ArticleResponse?>
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public string? Content { get; set; }
    public DateTime DatePublished { get; set; } =  DateTime.UtcNow;
    public bool IsPublished { get; set; } = false;
}