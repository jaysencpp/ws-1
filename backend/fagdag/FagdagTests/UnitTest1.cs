using Fagdag.Domain.Entities;
using Fagdag.Domain.Enums;
using FluentAssertions;
using System;
using Xunit;

namespace FagdagTests;

//TODO: Run all unit tests in this file
public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var todo = new Todo { Title = "Test", Id = Guid.NewGuid() };
        todo.Title.Should().Be("Test");
    }

    [Fact]
    public void Test2()
    {
        //TODO: Debug this specific test
        var todo = new Todo { Title = "Test", Id = Guid.NewGuid() }; //TODO: Set a breakpoint here
        todo.State.Should().Be(State.New);
    }
}
