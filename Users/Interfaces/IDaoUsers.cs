using Users.Repositories;
using Users.Models;

namespace Users.Interfaces
{
    public interface IDaoUsers : IBaseRepository<Entities.Users,string>
    {

    }
}
