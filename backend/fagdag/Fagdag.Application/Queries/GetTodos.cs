﻿using Fagdag.Application.Models;
using Fagdag.Infrastructure.Data.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Fagdag.Application.Queries;

public class GetTodos : IRequest<List<QueryTodo>>
{
    public class Handler(TodoDbContext context) : IRequestHandler<GetTodos, List<QueryTodo>>
    {
        public async Task<List<QueryTodo>> Handle(GetTodos request, CancellationToken cancellationToken)
        {
            var todos = await context
                .Todos
                .AsNoTracking()
                .Select(x => new QueryTodo { Title = x.Title, Id = x.Id })
                .ToListAsync(cancellationToken);
            return todos;
        }
    }
}
