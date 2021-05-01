using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodosWebApi.WebApi.Entities;

namespace TodosWebApi.Application.Commands
{
    public class AddTodoCommand : IRequest<TodoItem>
    {
        public string Title { get; set; }
    }
}
