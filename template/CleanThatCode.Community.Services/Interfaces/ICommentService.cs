using CleanThatCode.Community.Models.Dtos;

namespace CleanThatCode.Community.Services.Interfaces;

public interface ICommentService
{
    IEnumerable<CommentDto> GetAllCommentByPostId(int postId);
}