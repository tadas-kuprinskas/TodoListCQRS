using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TodosWebApi.Application.Queries;
using TodosWebApi.WebApi.Entities;
using TodosWebApi.WebApi.Interfaces;

namespace TodosWebApi.Application.Handlers
{ 
    public class GetAllTodosHandler : IRequestHandler<GetAllTodosQuery, IEnumerable<TodoItem>>
    {
        private readonly ITodoRepository _todoRepository;

        public GetAllTodosHandler(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public async Task<IEnumerable<TodoItem>> Handle(GetAllTodosQuery request, CancellationToken cancellationToken)
        {
            return await _todoRepository.Get();
        }
    }
}
