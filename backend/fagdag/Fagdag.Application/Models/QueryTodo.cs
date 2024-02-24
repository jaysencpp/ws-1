using System;
using Fagdag.Domain.Enums;

namespace Fagdag.Application.Models;

public class QueryTodo
{
    public Guid Id { get; set; }
    public required string Title { get; set; }
    public State State { get; set; }
}