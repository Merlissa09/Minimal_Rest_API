// Reminder: DTO stands for data transfer object
using TodoApi.Models;

public class TodoItemDTO
{
    public string? Name { get; set; }
    public bool IsComplete { get; set; }

    public TodoItemDTO() { }
    public TodoItemDTO(Todo todoItem) =>
    (Name, IsComplete) = (todoItem.TodoName, todoItem.IsComplete);
}