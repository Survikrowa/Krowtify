using backend.modules.auth;
using backend.modules.shared.database;

namespace backend.modules.user;

interface IUserService
{
    NormalUserModel? GetByName(string name);
}

public class UserService : IUserService
{
    private DataContext _context;

    public UserService()
    {
        _context = new DataContext();
    }
    
    public NormalUserModel? GetByName(string name)
    {
        return _context.Users.Find(name);
    }
}