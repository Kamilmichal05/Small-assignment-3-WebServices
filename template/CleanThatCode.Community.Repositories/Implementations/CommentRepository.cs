using CleanThatCode.Community.Models.Dtos;
using CleanThatCode.Community.Repositories.Data;
using CleanThatCode.Community.Repositories.Interfaces;

namespace CleanThatCode.Community.Repositories.Implementations;

public class CommentRepository(ICleanThatCodeDbContext dbContext) : ICommentRepository
{
    public IEnumerable<CommentDto> GetAllCommentsByPostId(int postId)
    {
        return dbContext.Comments.Where(c => c.PostId == postId).Select(c => new CommentDto
        {
            Id = c.Id,
            PostId = c.PostId,
            Author = c.Author,
            Message = c.Message,
            Created = c.Created
        });
    }
}