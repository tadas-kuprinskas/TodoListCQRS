using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TodosWebApi.Application.Commands;
using TodosWebApi.WebApi.Entities;
using TodosWebApi.WebApi.Interfaces;

namespace TodosWebApi.Application.Handlers
{
    public class AddTodoHandler : IRequestHandler<AddTodoCommand, TodoItem>
    {
        private readonly ITodoRepository _todoRepository;
        private readonly IMapper _mapper;

        public AddTodoHandler(ITodoRepository todoRepository, IMapper mapper)
        {
            _todoRepository = todoRepository;
            _mapper = mapper;
        }

        public async Task<TodoItem> Handle(AddTodoCommand request, CancellationToken cancellationToken)
        {
            var todo = _mapper.Map<TodoItem>(request);

            return await _todoRepository.Create(todo);
        }
    }
}
