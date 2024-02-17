using System;

namespace Fagdag.Domain.Exceptions;

public class TodoNotFoundException(Guid id) : Exception($"Todo with ID {id} was not found");