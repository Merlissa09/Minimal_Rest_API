using System.ComponentModel.DataAnnotations;
using TodoApi.Enums;

namespace TodoApi.Models;

public class User: BaseEntity
{
    [Required]
    public UserType Type = UserType.Guest;
}