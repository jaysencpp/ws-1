using Fagdag.Domain.Enums;
using System;

namespace Fagdag.Domain.Entities;

public class Todo
{
    public Guid Id { get; set; }
    public required string Title { get; set; }
    public State State { get; private set; } = State.New;

}
