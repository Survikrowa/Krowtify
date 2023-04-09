using backend.modules.user;
using Microsoft.AspNetCore.Mvc;

namespace backend.modules.auth;


[Route("api/auth")]
[ApiController]
public class AuthController : ControllerBase
{
    private UserService _userService;

    public AuthController()
    {
        _userService = new UserService();
    }
    // [HttpPost("/login")]
    // public IActionResult Login([FromBody] AuthNormalUserLoginModel user)
    // {
    //     
    // }
    [HttpPost("/register")]
    public IActionResult Register([FromBody] AuthNormalUserRegisterModel userFormData)
    {

        var user = _userService.GetByName(userFormData.Username);
        if (user)
        {
            
        }
    }
}