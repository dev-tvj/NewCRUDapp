using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CrudAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]

    public class UsersController : ControllerBase
    {
        private readonly Contexto _contexto;


        public UsersController(Contexto contexto)
        {
            _contexto = contexto;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetAllAsync() {
            return await _contexto.Users.ToListAsync();
        }

        [HttpGet("{UserId}")]
        public async Task<ActionResult<User>> GetUserByIdAsync(int UserId) {
            User user = await _contexto.Users.FindAsync(UserId);

            if (user == null) {
                return NotFound();
            } else
            {
                return user;
            }     

        }

        [HttpPost]
        public async Task<ActionResult<User>> SaveUserAsync(User user) {
            await _contexto.Users.AddAsync(user);
            await _contexto.SaveChangesAsync();

            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateUserAsync(User user) {
            _contexto.Users.Update(user);
            await _contexto.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{UserId}")]
        public async Task<ActionResult> DeleteUserAsync(int UserId) {
            User user = await _contexto.Users.FindAsync(UserId);

            if (user == null) {
                return NotFound();
            } else {

                _contexto.Remove(user);
                await _contexto.SaveChangesAsync();
                return Ok();
            }
        }
    }
}