using APIEstudos.models;
using APIEstudos.Requests;
using APIEstudos.Response;
using AutoMapper;

namespace APIEstudos.AutoMapper
{
    public class DomainProfileCore : Profile
    {
        public DomainProfileCore()
        {
            ClienteMap();
        }

        private void ClienteMap()
        {
            CreateMap<CreateUserRequest, UserModel>();
            CreateMap<UserModel, UserResponse>(); 
        }
    }
}
