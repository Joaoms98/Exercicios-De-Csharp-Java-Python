using APIEstudos.Interfaces;
using APIEstudos.models;
using APIEstudos.Requests;
using APIEstudos.Response;
using AutoMapper;
using MediatR;

namespace APIEstudos.Handlers.Commands
{
    public class CreateUserHandler : IUserCommand
    {
        protected readonly IUserService _userService;
        protected readonly IMapper _mapper;

        public CreateUserHandler(
            IMapper mapper,
            IUserService user
        ){
            _mapper = mapper;
            _userService = user;
        }

        public async Task<UserResponse> CreateUserAsync(CreateUserRequest request)
        {
            var userModel = _mapper.Map<UserModel>(request);
            return await _userService.CreateUserAsync(userModel);
        }
    }
}
