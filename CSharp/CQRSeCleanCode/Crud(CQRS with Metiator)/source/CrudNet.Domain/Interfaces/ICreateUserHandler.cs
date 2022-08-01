using System;
using crud_net_project.source.CrudNet.Domain.Commands.Requests;
using crud_net_project.source.CrudNet.Domain.Commands.Responses;

namespace crud_net_project.source.CrudNet.Domain.Handlers.Interfaces
{
    public interface ICreateUserHandler
    {
        CreateUserResponse Handle(CreateUserRequest request);
    }
}