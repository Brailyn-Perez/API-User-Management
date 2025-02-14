using Users.Context;
using Users.Interfaces;


namespace Users.Daos
{
    public class DaoUsers : IDaoUsers
    {
        private readonly UsersContext _context;

        public DaoUsers(UsersContext context)
        {
            _context = context;

        }

        public Task CreateAsync(Entities.Users entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Entities.Users>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Entities.Users> GetEntityByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Entities.Users entity)
        {
            throw new NotImplementedException();
        }
    }
}
