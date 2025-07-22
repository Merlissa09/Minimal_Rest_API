
using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models;

/// <summary>
/// Todo model
/// A model is a class that represents data that the app manages.
/// </summary>
public class Todo : BaseEntity
{
    public bool IsComplete { get; set; }
}

