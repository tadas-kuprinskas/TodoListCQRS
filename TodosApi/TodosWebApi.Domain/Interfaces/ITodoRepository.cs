using System.Collections.Generic;
using System.Threading.Tasks;
using TodosWebApi.WebApi.Dtos;
using TodosWebApi.WebApi.Entities;

namespace TodosWebApi.WebApi.Interfaces
{
    public interface ITodoRepository
    {
        Task<TodoItem> Create(TodoItem item);
        Task<int> DeleteTodoAsync(int id);
        Task<IEnumerable<TodoItem>> Get();
        Task ToggleTodo(TodoItem todo);
    }
}