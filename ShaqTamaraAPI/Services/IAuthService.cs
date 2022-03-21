using ShaqTamaraAPI.ViewModel;
using System.Threading.Tasks;

namespace ShaqTamaraAPI.Services
{
    public interface IAuthService
    {
        Task<AuthModel> RegisterAsync(AdminViewModel model);
        Task<AuthModel> GetTokenAsync(LoginAdmin model);
        Task<AuthModel> RegisterDonner(DonorViewModel model);
        Task<AuthModel> GetTokenDonner(LoginUser model);
        Task<AuthModel> Registervolunteer(VolunteerViewModel model);
        Task<AuthModel> GetTokenvolunteer(LoginUser model);
        Task<AuthModel> RegisterBeneficiary(BeneficiaryViewModel model);
        Task<AuthModel> GetTokenBeneficiary(LoginUser model);
        Task<string> AddRoleAsync(AddRoleModel model);
    }
}
