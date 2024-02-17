using System;

namespace Fagdag.Domain.Entities;

public class Todo
{
    public Guid Id { get; set; }
    public required string Title { get; set; }
}