using System.ComponentModel.DataAnnotations;
using TodoApi.Enums;

namespace TodoApi.Models;

public interface IUser
{
    public void LogDetailsToConsole();
}

public abstract class User : BaseEntity
{
    [Required]
    public UserType Type = UserType.Guest;

    public override void LogDetailsToConsole()
    {
        Console.WriteLine($"In the User Entity. The Id is: {Id}; The Name is: {Name}");
    }
}

public class SuperUser : User
{
    public SuperUser()
    {
        Type = UserType.Super;
    }
}

public class GuestUser : User
{
    public GuestUser()
    {
    }
}

public class AdminUser : User
{
    public AdminUser()
    {
        Type = UserType.Admin;
    }
}
