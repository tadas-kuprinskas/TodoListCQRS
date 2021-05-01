using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodosWebApi.Application.Commands;
using TodosWebApi.WebApi.Entities;

namespace TodosWebApi.Application.Mapping
{
    public class MappingProfile : AutoMapper.Profile
    {
        public MappingProfile()
        {
            CreateMap<TodoItem, AddTodoCommand>().ReverseMap();
            CreateMap<TodoItem, UpdateTodoCommand>().ReverseMap();
        }
    }
}
