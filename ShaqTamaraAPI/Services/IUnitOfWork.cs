using ShaqTamaraAPI.Data.Models;
using System;

namespace ShaqTamaraAPI.Services
{
    public interface IUnitOfWork : IDisposable
    {

        IBaseRepository<Post> Posts { get; }
        IBaseRepository<Comment> Comments { get; }
        IBaseRepository<Like> Likes { get; }
        IBaseRepository<Order> Orders { get; }
        IBaseRepository<Donation> Donations { get; }
        IBaseRepository<ApplicationUser> ApplicationUsers { get; }


        int Complete();
    }

}
