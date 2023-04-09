using System.ComponentModel.DataAnnotations;

namespace backend.modules.auth;

public class NormalUserModel
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
}

public class AuthNormalUserLoginModel
{
    [Required]
    public string Username { get; set; }
    [Required]
    public string Password { get; set; }
}

public class AuthNormalUserRegisterModel
{
    [Required] 
    public string Username { get; set; }
    [Required] 
    public string Password { get; set; }
    [Required]
    public string Email { get; set; }
}

public class AuthenticatedResponseModel
{
    public string? Token { get; set; }
}