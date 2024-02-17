using System;

namespace FagdagAPI.Domain.Exceptions;

public class TodoNotFoundException(Guid id) : Exception($"Todo with ID {id} was not found");