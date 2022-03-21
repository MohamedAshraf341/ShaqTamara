using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShaqTamaraAPI.Data.Models;
using ShaqTamaraAPI.Services;
using System.Threading.Tasks;

namespace ShaqTamaraAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CommentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet("AllComments")]
        public async Task<IActionResult> GetAllComments()
        {
            return Ok(await _unitOfWork.Comments.GetAllAsync());
        }
        [HttpPost("CreateComment")]
        public async Task<IActionResult> CreatePost(Comment comment)
        {
            return Ok(await _unitOfWork.Comments.AddAsync(comment));
        }
        [HttpPut("UpdateComment")]
        public IActionResult UpdatePost(Comment comment)
        {
            return Ok(_unitOfWork.Comments.Update(comment));
        }
        [HttpDelete("DeleteComment")]
        public IActionResult DeletePost(Comment comment)
        {
            return Ok(_unitOfWork.Comments.Delete(comment));
        }
    }

}
