using System;
using System.Threading;
using System.Threading.Tasks;
using Fagdag.Domain.Entities;
using Fagdag.Infrastructure.Data.Context;
using MediatR;

namespace Fagdag.Application.Commands;

public class CreateTodo(string title) : IRequest<Guid>
{
    public string Title { get; set; } = title;

    public class Handler(TodoDbContext context) : IRequestHandler<CreateTodo, Guid>
    {
        public async Task<Guid> Handle(CreateTodo request, CancellationToken cancellationToken)
        {
            var entity = new Todo
            {
                Title = request.Title,
                Id = Guid.NewGuid()
            };
            context.Todos.Add(entity);
            await context.SaveChangesAsync(cancellationToken);
            return entity.Id;
        }
    }
}