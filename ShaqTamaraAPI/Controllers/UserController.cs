using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShaqTamaraAPI.Data.Models;
using ShaqTamaraAPI.Services;
using System.Threading.Tasks;

namespace ShaqTamaraAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet("AllUser")]
        public async Task<IActionResult> GetAllUser()
        {
            return Ok(await _unitOfWork.ApplicationUsers.GetAllAsync());
        }
        [HttpPut("UpdateUser")]
        public IActionResult UpdatePost(ApplicationUser ApplicationUser)
        {
            return Ok(_unitOfWork.ApplicationUsers.Update(ApplicationUser));
        }
        [HttpDelete("DeleteUser")]
        public IActionResult DeletePost(ApplicationUser ApplicationUser)
        {
            return Ok(_unitOfWork.ApplicationUsers.Delete(ApplicationUser));
        }

    }
}
