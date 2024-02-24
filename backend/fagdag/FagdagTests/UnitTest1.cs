using System;
using Fagdag.Domain.Entities;
using FluentAssertions;
using Xunit;

namespace FagdagTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var todo = new Todo{Title = "Test", Id = Guid.NewGuid()};
        todo.Title.Should().Be("Test");
    }
}