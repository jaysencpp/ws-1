using System;

namespace FagdagAPI.Application.Models;

public class QueryTodo
{
    public Guid Id { get; set; }
    public required string Title { get; set; }
}