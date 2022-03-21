using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShaqTamaraAPI.Data.Models;
using ShaqTamaraAPI.Services;
using System.Threading.Tasks;

namespace ShaqTamaraAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrderController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet("AllOrders")]
        public async Task<IActionResult> GetAllOrder()
        {
            return Ok(await _unitOfWork.Orders.GetAllAsync());
        }
        [HttpPost("CreateOrder")]
        public async Task<IActionResult> CreatePost(Order order)
        {
            return Ok(await _unitOfWork.Orders.AddAsync(order));
        }
        [HttpPut("UpdateOrder")]
        public IActionResult UpdatePost(Order order)
        {
            return Ok(_unitOfWork.Orders.Update(order));
        }
        [HttpDelete("DeleteOrder")]
        public IActionResult DeletePost(Order order)
        {
            return Ok(_unitOfWork.Orders.Delete(order));
        }

    }

}
