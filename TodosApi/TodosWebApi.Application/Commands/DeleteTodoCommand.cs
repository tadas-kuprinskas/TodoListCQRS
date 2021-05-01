using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodosWebApi.Application.Commands
{
    public class DeleteTodoCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
