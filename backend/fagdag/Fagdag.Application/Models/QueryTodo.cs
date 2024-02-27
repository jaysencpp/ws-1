using Fagdag.Domain.Enums;
using System;

namespace Fagdag.Application.Models;

public class QueryTodo
{
    public Guid Id { get; set; }
    public required string Title { get; set; }
    public State State { get; set; }
}
