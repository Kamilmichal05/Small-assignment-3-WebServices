using CleanThatCode.Community.Models.Dtos;
using CleanThatCode.Community.Repositories.Interfaces;
using CleanThatCode.Community.Services.Interfaces;

namespace CleanThatCode.Community.Services.Implementations;

public class CommentService(ICommentRepository commentRepository) : ICommentService
{
    public IEnumerable<CommentDto> GetAllCommentByPostId(int postId) => commentRepository.GetAllCommentsByPostId(postId);
}