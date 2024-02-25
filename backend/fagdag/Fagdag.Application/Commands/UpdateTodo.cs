using System;
using System.Threading;
using System.Threading.Tasks;
using Fagdag.Application.Queries;
using Fagdag.Infrastructure.Data.Context;
using MediatR;

namespace Fagdag.Application.Commands;

public class UpdateTodo(Guid todoId, string? title, string? state) : IRequest
{
    public Guid TodoId { get; set; } = todoId;
    public string? Title { get; set; } = title;
    
    //TODO: Make this property private
    public string? State { get; set; } = state;
    
    public class Handler(TodoDbContext ctx, ISender mediator) : IRequestHandler<UpdateTodo>
    {
        public async Task Handle(UpdateTodo request, CancellationToken cancellationToken)
        {
            var todoQuery = new GetTodoById(request.TodoId);
            var todo = await mediator.Send(todoQuery, cancellationToken);

            if (!string.IsNullOrEmpty(request.Title))
            {
                todo.Title = request.Title;
            }

            if (!string.IsNullOrEmpty(request.State))
            {
                if(Enum.TryParse(request.State, out Domain.Enums.State parsedState))
                {
                    //TODO: Extract Method for these two if checks
                    if (todo.State == Domain.Enums.State.Done)
                    {
                        throw new ArgumentException("Not allowed");
                    }

                    if (todo.State == Domain.Enums.State.New && parsedState == Domain.Enums.State.Done)
                    {
                        throw new ArgumentException("Not allowed");
                    }

                    todo.State = parsedState;
                }
            }

            await ctx.SaveChangesAsync(cancellationToken);
        }
    }
}