using System;
public partial class User
{
    public string UserName { get; set; }
    public string Password { get; set; }

    public User(string userName, string password)
    {
        this.UserName = userName;
        this.Password = password;
    }
}
