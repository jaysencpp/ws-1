using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fagdag.Application.Commands;
using Fagdag.Application.Queries;
using Fagdag.Domain.Abstractions;
using Fagdag.Domain.Exceptions;
using Fagdag.Presentation.RequestModels;
using Fagdag.Presentation.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FagdagAPI.Controllers;

//TODO: Rename meiator to be mediator
public class TodoController(ISender meiator, IMailSender mailSender) : ControllerBase
{
    [HttpGet("todos")]
    public async Task<ActionResult<List<ApiTodo>>> GetTodos()
    {
        //TODO: Introduce variables:
        // var query = new GetTodos()
        // var todos = await meiator.send(query)
        // var result = todos.Select(x => new ApiTodo { Title = x.Title })
        return Ok((await meiator.Send(new GetTodos())).Select(x => new ApiTodo { Title = x.Title }));
    }

    [HttpPost("todos")]
    public async Task<IActionResult> CreateTodo([FromBody] TodoRequest request)
    {
        var command = new CreateTodo(request.Title);
        var todoId = await meiator.Send(command);
        var todo = await meiator.Send(new GetTodoById(todoId));
        //TODO: Go to implementation of SendMail
        await mailSender.SendMail("mail@bouvet.no", "Todo created!");
        return CreatedAtAction(nameof(GetTodo), new { id = todoId }, todo);
    }

    [HttpGet("todos/{id:guid}")]
    public async Task<ActionResult<ApiTodo>> GetTodo([FromRoute] Guid id)
    {
        var query = new GetTodoById(id);

        //TODO: Comment this line out
        Console.WriteLine("Hello World");
        try
        {
            var todo = await meiator.Send(query);
            return Ok(new ApiTodo { Title = todo.Title });
        }
        catch (TodoNotFoundException ex)
        {
            return NotFound(ex.Message);
        }
    }

    [HttpPatch("todos/{id:guid}")]
    public async Task<ActionResult<ApiTodo>> UpdateTodo([FromRoute] Guid id, [FromBody] UpdateTodoRfuest request)
    {
        var command = new UpdateTodo(id, request.Title, request.State);

        // TODO: Surround this block of code with try catch. Return bad Request if exception. **Use keybinds or refactoring tool**
        await meiator.Send(command);
        var todoQuery = new GetTodoById(id);
        var todo = await meiator.Send(todoQuery);
        return Ok(new ApiTodo { Title = todo.Title });
    }
}