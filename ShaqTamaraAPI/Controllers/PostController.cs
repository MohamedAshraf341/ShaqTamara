using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShaqTamaraAPI.Data.Models;
using ShaqTamaraAPI.Services;
using System.Threading.Tasks;

namespace ShaqTamaraAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public PostController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet("AllPosts")]
        public async Task<IActionResult> GetAllPosts()
        {
            return Ok(await _unitOfWork.Posts.GetAllAsync());
        }
        [HttpPost("CreatePost")]
        public async Task<IActionResult> CreatePost(Post post)
        {
            return Ok(await _unitOfWork.Posts.AddAsync(post));
        }
        [HttpPut("UpdatePost")]
        public IActionResult UpdatePost(Post post)
        {
            return Ok(_unitOfWork.Posts.Update(post));
        }
        [HttpDelete("DeletePost")]
        public IActionResult DeletePost(Post post)
        {
            return Ok(_unitOfWork.Posts.Delete(post));
        }

    }
}
