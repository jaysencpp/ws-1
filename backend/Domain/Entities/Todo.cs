using System;

namespace FagdagAPI.Domain.Entities;

public class Todo
{
    public Guid Id { get; set; }
    public required string Title { get; set; }
}