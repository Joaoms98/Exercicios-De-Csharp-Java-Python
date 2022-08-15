using APIEstudos.models;
using APIEstudos.Requests;
using APIEstudos.Response;

namespace APIEstudos.Interfaces
{
    public interface IUserCommand
    {
        Task<UserResponse> CreateUserAsync(CreateUserRequest User);
    }
}
