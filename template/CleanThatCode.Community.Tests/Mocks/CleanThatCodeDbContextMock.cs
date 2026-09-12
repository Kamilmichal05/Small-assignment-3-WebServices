using System.Globalization;
using CleanThatCode.Community.Models.Entities;
using CleanThatCode.Community.Repositories.Data;

namespace CleanThatCode.Community.Tests.Mocks;

public class CleanThatCodeDbContextMock : ICleanThatCodeDbContext
{
    public IEnumerable<Post> Posts => FakeData.Posts;
    public IEnumerable<Comment> Comments => FakeData.Comments;
}