using Domain.Entities;
using Domain.Ports;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;

    public UsersController(IUserService clubService) =>
        _userService = clubService;

    [HttpGet]
    public async Task<IActionResult> GetAllUsers()
    {
        var users = await _userService.GetAllUsersAsync();

        return Ok(users);
    }

    [HttpPost]
    public async Task<IActionResult> RegisterUser(User user)
    {
        await _userService.AddNewUserAsync(user);

        return Ok(user);
    }
    [HttpPut("{id:Guid}")]
    public async Task<IActionResult> UpdateUser(Guid id, User user)
    {
        if (id != user.Id)
        {
            return BadRequest();
        }

        await _userService.UpdateUserAsync(user);

        return Ok(user);
    }
    [HttpDelete("{id:Guid}")]
    public async Task<IActionResult> DeleteUser(Guid id)
    {
        var user = await _userService.DeleteUserAsync(id);

        return Ok(user);
    }
}
