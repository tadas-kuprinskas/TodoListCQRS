using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodosWebApi.WebApi.Entities;

namespace TodosWebApi.Application.Queries
{
    public class GetAllTodosQuery : IRequest<IEnumerable<TodoItem>>
    {
    }
    
}
