using Microsoft.AspNetCore.Mvc;
using ITQ2_BSIT32E1_MENDOZA_STEPHANIE.Data;
using ITQ2_BSIT32E1_MENDOZA_STEPHANIE.Models.Users;
using ITQ2_BSIT32E1_MENDOZA_STEPHANIE.Models.UsersGroup;

namespace ITQ2_BSIT32E1_MENDOZA_STEPHANIE.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersGroup : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
    {
        var value = new GetUsersGroupResponse();
        return Ok();
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        if (id > 2)
        {
            return NotFound();
        }

        if (id == 0)
        {
            return BadRequest();
        }

        if (id < 0)
        {
            return NoContent();
        }

        var response = new GetByUserGroupIdResponse();
        response.UserDtos.Add(new GetUserDto
        {
            Id = 1,
            Name = "Steph",
            Email = "steph@gmail.com"
        });

        return Ok();
    }

    [HttpPost]
    public IActionResult Create(CreateUsersGroupRequest request)
    {
        var newGroup = new Data.UsersGroup();
        newGroup.Id = UsersRepository.UserGroupsList.Count + 1;
        newGroup.Name = request.Name;

        UsersRepository.UserGroupsList.Add(newGroup);
        return Ok();
    }

    [HttpPut]
    public IActionResult Edit(EditUsersGroupRequest request)
    {
        if (request.Id < 2)
        {
            return BadRequest();
        }

        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        if (id < 2)
        {
            return BadRequest();
        }

        return Ok();
    }
}