using BookWeb.Dtos;
using BookWeb.Entities;
using BookWeb.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookWeb.Controllers
{
    [Route("api/role")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private IRole _role;
        public RoleController(IRole role)
        {
            _role = role;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Post([FromBody] RoleDto registerRole)
        {
            ApplicationRole role = new ApplicationRole();
            role.Name = registerRole.RoleName;
            role.RoleName = registerRole.RoleName;

            var newRole = await _role.CreateRole(role);

            if (newRole)
            {
                return Ok(new { message = "Role Created" });

            }
            else
            {
                return BadRequest(new { message = "Role not created" });
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var r = await _role.GetAll();
            return Ok(r);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(String id)
        {
            var role = await _role.GetById(id);
            return Ok(role);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(String id, [FromBody] ApplicationRole role)
        {
            role.Id = id;
            var update = await _role.Update(role);

            if (update)
            {
                return Ok("Role Updated");
            }
            else
            {
                return BadRequest(new { message = "Unable to update Role details" });
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(String id)
        {
            var deleteRole = await _role.DeleteRole(id);
            if (deleteRole)
            {
                return Ok("Role Deleted");
            }
            else
            {
                return BadRequest(new { message = "Unable to delete Role details" });
            }
        }
    }
}
