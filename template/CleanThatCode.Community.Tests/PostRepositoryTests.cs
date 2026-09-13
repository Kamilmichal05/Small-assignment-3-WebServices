using Microsoft.VisualStudio.TestTools.UnitTesting;
using CleanThatCode.Community.Repositories.Data;
using CleanThatCode.Community.Models.Entities;
using CleanThatCode.Community.Repositories.Implementations;
using Bogus;
using Moq;

namespace CleanThatCode.Community.Tests;

[TestClass]
public class PostRepositoryTests
{
    private static PostRepository CreateSut()
    {
        var fakePosts = CreateFakePosts();

        var mockDbContext = new Mock<ICleanThatCodeDbContext>();
        mockDbContext.Setup(x => x.Posts).Returns(fakePosts);

        return new PostRepository(mockDbContext.Object);
    }

    private static List<Post> CreateFakePosts()
    {
        var grayskullFaker = new Faker<Post>
        .RuleFor(p => p.Title, f => $"{f.Lorem.Sentence(3)} Grayskull")
        .RuleFor(p => p.Author, _ => "He-Man");

        var stallmanFaker = new Faker<Post>
        .RuleFor(p => p.Title, f => $"{f.Lorem.Sentence(3)} Hack the planet!")
        .RuleFor(p => p.Author, _ => "Richard Stallman");

        return new List<Post>
        {
            grayskullFaker.Generate()
            grayskullFaker.Generate()
            stallmanFaker.Generate()
        };
    }

    [TestMethod]
    public void GetAllPosts_NoFilter_ShouldContainAListOfTwo()
    {
        var sut = CreateSut();
        var result = sut.GetAllPosts("", "");
        Assert.AreEqual(3, result.Count());
    }
}