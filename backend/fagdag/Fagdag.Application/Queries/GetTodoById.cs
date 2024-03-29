﻿using Fagdag.Application.Models;
using Fagdag.Domain.Exceptions;
using Fagdag.Infrastructure.Data.Context;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Fagdag.Application.Queries;

public class GetTodoById(Guid id) : IRequest<QueryTodo>
{
    public Guid Id { get; set; } = id;

    public class Handler(TodoDbContext context) : IRequestHandler<GetTodoById, QueryTodo>
    {
        public async Task<QueryTodo> Handle(GetTodoById request, CancellationToken cancellationToken)
        {
            var todo = await context.Todos.FindAsync([request.Id], cancellationToken: cancellationToken);

            if (todo is null)
                throw new TodoNotFoundException(request.Id);

            return new QueryTodo { Title = todo.Title, Id = todo.Id, State = todo.State };
        }
    }
}
