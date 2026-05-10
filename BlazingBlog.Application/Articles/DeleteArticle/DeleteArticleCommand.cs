using MediatR;

namespace BlazingBlog.Application.Articles.DeleteArticle;

public class DeleteArticleCommand : IRequest<bool>
{
    public int Id { get; set; }
}   