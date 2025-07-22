using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models;

public class TodoList: BaseEntity
{
    public Todo[]? Todos;
}