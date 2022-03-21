using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShaqTamaraAPI.Data.Models;
using ShaqTamaraAPI.Services;
using System.Threading.Tasks;

namespace ShaqTamaraAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonationController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public DonationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet("AllDonations")]
        public async Task<IActionResult> GetAllDonations()
        {
            return Ok(await _unitOfWork.Donations.GetAllAsync());
        }
        [HttpPost("CreateDonation")]
        public async Task<IActionResult> CreatePost(Donation donation)
        {
            return Ok(await _unitOfWork.Donations.AddAsync(donation));
        }
        [HttpPut("UpdateDonation")]
        public IActionResult UpdatePost(Donation donation)
        {
            return Ok(_unitOfWork.Donations.Update(donation));
        }
        [HttpDelete("DeleteDonation")]
        public IActionResult DeletePost(Donation donation)
        {
            return Ok(_unitOfWork.Donations.Delete(donation));
        }
    }

}
