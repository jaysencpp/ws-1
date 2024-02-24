using System;
using Fagdag.Domain.Enums;

namespace Fagdag.Domain.Entities;

public class Todo
{
    public Guid Id { get; set; }
    public required string Title { get; set; }
    public State State { get; private set; } = State.New;
    
    public void SetTodoState(State newState)  {
        
    }
}