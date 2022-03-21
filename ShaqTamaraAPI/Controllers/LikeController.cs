using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShaqTamaraAPI.Data.Models;
using ShaqTamaraAPI.Services;
using System.Threading.Tasks;

namespace ShaqTamaraAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LikeController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public LikeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpPost("CreateLike")]
        public async Task<IActionResult> CreatePost(Like like)
        {
            return Ok(await _unitOfWork.Likes.AddAsync(like));
        }
        [HttpPut("UpdateLike")]
        public IActionResult UpdatePost(Like like)
        {
            return Ok(_unitOfWork.Likes.Update(like));
        }
        [HttpDelete("DeleteLike")]
        public IActionResult DeletePost(Like like)
        {
            return Ok(_unitOfWork.Likes.Delete(like));
        }
    }

}
