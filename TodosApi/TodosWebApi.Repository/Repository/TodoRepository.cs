using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodosWebApi.WebApi.Data;
using TodosWebApi.WebApi.Dtos;
using TodosWebApi.WebApi.Entities;
using TodosWebApi.WebApi.Interfaces;

namespace TodosWebApi.WebApi.Repository
{
    public class TodoRepository : ITodoRepository
    {
        private readonly DataContext _context;

        public TodoRepository(DataContext dataContext)
        {
            _context = dataContext;
        }

        public async Task<IEnumerable<TodoItem>> Get()
        {
            return await _context.Todos.ToListAsync();
        }

        public async Task<TodoItem> Create(TodoItem todo)
        {
            _context.Set<TodoItem>().Add(todo);
            await _context.SaveChangesAsync();
            return todo;
        }

        public async Task ToggleTodo(TodoItem todo)
        {
            _context.Update(todo);
            await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteTodoAsync(int id)
        {
            var todo = await _context.Todos.FindAsync(id);
            _context.Todos.Remove(todo);
            await _context.SaveChangesAsync();
            return todo.Id;
        }
    }
}
