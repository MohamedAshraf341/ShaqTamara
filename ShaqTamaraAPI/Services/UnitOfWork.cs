using ShaqTamaraAPI.Data;
using ShaqTamaraAPI.Data.Models;

namespace ShaqTamaraAPI.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;


        public IBaseRepository<Post> Posts { get; private set; }
        public IBaseRepository<Comment> Comments { get; private set; }
        public IBaseRepository<Like> Likes { get; private set; }
        public IBaseRepository<ApplicationUser> ApplicationUsers { get; private set; }
        public IBaseRepository<Order> Orders { get; private set; }
        public IBaseRepository<Donation> Donations { get; private set; }
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;

            //Authors = new BaseRepository<Author>(_context);
            //Books = new BooksRepository(_context);
            Posts = new BaseRepository<Post>(_context);
            Comments = new BaseRepository<Comment>(_context);
            Likes = new BaseRepository<Like>(_context);
            ApplicationUsers = new BaseRepository<ApplicationUser>(_context);
            Orders = new BaseRepository<Order>(_context);
            Donations = new BaseRepository<Donation>(_context);

        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }

}
