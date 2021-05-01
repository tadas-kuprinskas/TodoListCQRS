using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TodosWebApi.Application.Commands;
using TodosWebApi.WebApi.Interfaces;

namespace TodosWebApi.Application.Handlers
{
    public class DeleteTodoHandler : IRequestHandler<DeleteTodoCommand, int>
    {
        private readonly ITodoRepository _todoRepository;

        public DeleteTodoHandler(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public async Task<int> Handle(DeleteTodoCommand request, CancellationToken cancellationToken)
        {
            return await _todoRepository.DeleteTodoAsync(request.Id);
        }
    }

}
