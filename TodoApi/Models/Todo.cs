
using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models;

/// <summary>
/// Todo model
/// A model is a class that represents data that the app manages.
/// </summary>
public class Todo : BaseEntity
{
    public string? TodoName
    {
        get { return Name; }
        set { Name = value; }
    }

    public bool IsComplete { get; set; }


    public Todo() : base()
    {
        Console.WriteLine("This is the todo constructor");
    }

    public Todo(TodoItemDTO todoItemDTO)
    {
        IsComplete = todoItemDTO.IsComplete;
        Name = todoItemDTO.Name;
        Console.WriteLine("This is the todo constructor that sets the data");
    }

    public override void LogDetailsToConsole()
    {
        //base.LogDetailsToConsole();
        Console.WriteLine($"In the Todo Entity. The Id is: {Id}; The Name is: {Name}");
    }
}

