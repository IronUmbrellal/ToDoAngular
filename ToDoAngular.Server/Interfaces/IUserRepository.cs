using ToDoAngular.Server.DataAccess;
namespace ToDoAngular.Server.Interfaces
{
    public interface IUserRepository
    {
        Task CreateUserAsync(User user);
        Task<User?> GetUserByEmailAsync(string email);
        Task UpdateUser(User user);

    }
}
