using Microsoft.VisualStudio.TestTools.UnitTesting;
using CleanThatCode.Community.Tests.Mocks;
using CleanThatCode.Community.Repositories.Implementations;

namespace CleanThatCode.Community.Tests;

[TestClass]

public class CommentRepositoryTests
{   
    
    [TestMethod]

    public void GetAllCommentsByPostId_GivenWrongPostId_ShouldReturnNoComments()
    {
    var mocked_version = new CleanThatCodeDbContextMock();
    var repo = new CommentRepository(mocked_version);
    var all_comments = repo.GetAllCommentsByPostId(100);
    Assert.AreEqual(0, all_comments.Count());
    }
    [TestMethod]

    public void GetAllCommentsByPostId_GivenValidPostId_ShouldReturnTwoComments()
    {
    var mocked_version = new CleanThatCodeDbContextMock();
    var repo = new CommentRepository(mocked_version);
    var all_comments = repo.GetAllCommentsByPostId(1);
    Assert.AreEqual(2, all_comments.Count());
    }

    
}