namespace TodoApi.Enums;
/// <summary>
/// Super user is someone who is logged into the application and is able to save and manage their lists
/// Guest user is someone who is not logged into the application and can create temporary lists but they will not be stored permanently
/// Admin user is an employee who is able to access lists for themselves and other users
/// </summary>
public enum UserType { Super, Guest, Admin }