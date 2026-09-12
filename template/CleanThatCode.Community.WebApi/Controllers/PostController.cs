using CleanThatCode.Community.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CleanThatCode.Community.WebApi.Controllers;

[ApiController]
[Route("api/posts")]
public class PostController(IPostService postService, ICommentService commentService) : ControllerBase
{
    [HttpGet("")]
    public IActionResult GetAllPosts([FromQuery] string titleFilter = "", [FromQuery] string authorFilter = "")
    {
        return Ok(postService.GetAllPosts(titleFilter, authorFilter));
    }

    [HttpGet("{postId:int}/comments")]
    public IActionResult GetCommentsByPostId(int postId)
    {
        return Ok(commentService.GetAllCommentByPostId(postId));
    }
}