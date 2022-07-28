using System.Threading.Tasks;

namespace UserManagement.Infrastucture
{
    public interface IDatabaseInitializer {
        Task InitDbData();
    }

    public class DatabaseInitializer : IDatabaseInitializer
    {

        private readonly ApplicationDbContext _dbcontext;
        public DatabaseInitializer(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task InitDbData()
        {
           await _dbcontext.Database.EnsureCreatedAsync().ConfigureAwait(false);
            #region null user time

            //if (!_dbcontext.Users.Any())
            //{
            //    var user1 = new User
            //    {
            //        FullName = "test user 1",
            //        MobileNumber = "8675879573",
            //        Username = "Navin"
            //    };
            //    _dbcontext.Users.Add(user1);
            //    _dbcontext.SaveChanges();
            //}

            #endregion
        }
    }
}
