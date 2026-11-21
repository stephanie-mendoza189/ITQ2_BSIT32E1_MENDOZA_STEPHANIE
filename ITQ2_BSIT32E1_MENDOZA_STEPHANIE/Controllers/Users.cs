using Microsoft.AspNetCore.Mvc;
using ITQ2_BSIT32E1_MENDOZA_STEPHANIE.Data;
using ITQ2_BSIT32E1_MENDOZA_STEPHANIE.Models.Users;

namespace ITQ2_BSIT32E1_MENDOZA_STEPHANIE.Controllers;

[ApiController]
[Route("api/[controller]")]
public class Users : ControllerBase
{



    [HttpGet]
    public IActionResult GetAll()
    {
        var value = new GetUsersResponse();

        if (UsersRepository.UsersList.Count > 0)
        {
            value.UserDtos.Add(new GetUserDto
            {
                Id = UsersRepository.UsersList[0].Id,
                Name = UsersRepository.UsersList[0].Name,
                Email = UsersRepository.UsersList[0].Email
            });
        }

        if (UsersRepository.UsersList.Count > 1)
        {
            value.UserDtos.Add(new GetUserDto
            {
                Id = UsersRepository.UsersList[1].Id,
                Name = UsersRepository.UsersList[1].Name,
                Email = UsersRepository.UsersList[1].Email
            });
        }

        if (UsersRepository.UsersList.Count > 2)
        {
            value.UserDtos.Add(new GetUserDto
            {
                Id = UsersRepository.UsersList[2].Id,
                Name = UsersRepository.UsersList[2].Name,
                Email = UsersRepository.UsersList[2].Email
            });
        }

        return Ok(value);
    }


    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        if (id == 0)
        {
            return BadRequest();
        }

        if (id < 0)
        {
            return NoContent();
        }

        if (id > UsersRepository.UsersList.Count)
        {
            return NotFound();
        }

        var item = UsersRepository.UsersList[id - 1];
        var response = new GetByUserIdResponse();
        response.Id = item.Id;
        response.Name = item.Name;
        response.Email = item.Email;

        return Ok(response);
    }








    //createee
    [HttpPost]
    public IActionResult Create(CreateUsersRequest request)
    {
        var newUser = new Data.Users();
        newUser.Id = UsersRepository.UsersList.Count + 1;
        newUser.Name = request.Name;
        newUser.Email = request.Email;

        UsersRepository.UsersList.Add(newUser);
        return Ok();
    }


    //updateee
    [HttpPut]
    public IActionResult Edit(EditUsersRequest request)
    {
        if (request.Id < 1 || request.Id > UsersRepository.UsersList.Count)
        {
            return BadRequest();
        }

        var item = UsersRepository.UsersList[request.Id - 1];
        item.Name = request.Name;
        item.Email = request.Email;

        return Ok();
    }










    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        if (id < 1)
        {
            return BadRequest();
        }

        if (id > UsersRepository.UsersList.Count)
        {
            return NotFound();
        }

        UsersRepository.UsersList.RemoveAt(id - 1);
        return Ok();
    }






}