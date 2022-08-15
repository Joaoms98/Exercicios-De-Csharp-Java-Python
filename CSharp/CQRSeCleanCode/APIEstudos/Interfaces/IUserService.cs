using APIEstudos.models;
using APIEstudos.Response;

namespace APIEstudos.Interfaces
{
    public interface IUserService
    {
        Task<UserResponse> CreateUserAsync(UserModel user);
    }
}
