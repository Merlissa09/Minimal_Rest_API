using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models;

public abstract class BaseEntity
{
    [Required]
    public int Id { get; set; }
    [Required]
    protected string? Name { get; set; }

    public BaseEntity()
    {
        LogDetailsToConsole();
    }

    public virtual void LogDetailsToConsole()
    {
        Console.WriteLine($"In the Base Entity. The Id is: {Id}; The Name is: {Name}");
    }
}