using CleanThatCode.Community.Models.Dtos;
using CleanThatCode.Community.Repositories.Interfaces;
using CleanThatCode.Community.Services.Interfaces;

namespace CleanThatCode.Community.Services.Implementations;

public class PostService(IPostRepository postRepository) : IPostService
{
    public IEnumerable<PostDto> GetAllPosts(string titleFilter, string authorFilter) => postRepository.GetAllPosts(titleFilter, authorFilter);
}