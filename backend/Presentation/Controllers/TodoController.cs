using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FagdagAPI.Application.Commands;
using FagdagAPI.Application.Queries;
using FagdagAPI.Domain.Exceptions;
using FagdagAPI.Presentation.RequestModels;
using FagdagAPI.Presentation.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FagdagAPI.Controllers;

public class TodoController(ISender mediator) : ControllerBase
{
    [HttpGet("todos")]
    public async Task<ActionResult<List<ApiTodo>>> GetTodos()
    {
        var query = new GetTodos();
        var todos = await mediator.Send(query);
        return Ok(todos.Select(x => new ApiTodo { Title = x.Title }));
    }

    [HttpPost("todos")]
    public async Task<IActionResult> CreateTodo([FromBody] TodoRequest request)
    {
        var command = new CreateTodo(request.Title);
        var todoId = await mediator.Send(command);
        var todo = await mediator.Send(new GetTodoById(todoId));
        return CreatedAtAction(nameof(GetTodo), new { id = todoId }, todo);
    }

    [HttpGet("todos/{id:guid}")]
    public async Task<ActionResult<ApiTodo>> GetTodo([FromRoute] Guid id)
    {
        var query = new GetTodoById(id);

        try
        {
            var todo = await mediator.Send(query);
            return Ok(new ApiTodo { Title = todo.Title });
        }
        catch (TodoNotFoundException ex)
        {
            return NotFound(ex.Message);
        }
    }
}