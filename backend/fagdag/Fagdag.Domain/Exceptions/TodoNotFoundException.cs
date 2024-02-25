using System;

namespace Fagdag.Domain.Exceptions;

public class TodoNotFoundException : Exception
{
    //TODO: Convert to Primary Constructor
    public TodoNotFoundException(Guid id) : base($"Todo with ID {id} was not found")
    {
    }
}