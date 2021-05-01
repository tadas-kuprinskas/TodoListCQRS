using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodosWebApi.WebApi.Entities;

namespace TodosWebApi.Application.Commands
{
    public class UpdateTodoCommand : IRequest<TodoItem>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Completed { get; set; } = false;
    }
}
