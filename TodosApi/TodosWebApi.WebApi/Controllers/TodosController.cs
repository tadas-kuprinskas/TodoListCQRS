using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodosWebApi.Application.Commands;
using TodosWebApi.Application.Queries;
using TodosWebApi.WebApi.Dtos;
using TodosWebApi.WebApi.Entities;
using TodosWebApi.WebApi.Interfaces;

namespace TodosWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodosController : ControllerBase
    {        
        private readonly IMediator _mediator;

        public TodosController(IMediator mediator)
        {          
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<TodoItem>> Get()
        {
            return await _mediator.Send(new GetAllTodosQuery());
        }

        [HttpPost]
        public async Task<TodoItem> Create(AddTodoCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task ToggleTodo(UpdateTodoCommand command)
        {
            await _mediator.Send(command);
        }

        [HttpDelete("{id}")]
        public async Task DeleteTodoAsync(int id)
        {
            await _mediator.Send(new DeleteTodoCommand() { Id = id });
        }
    }

}
