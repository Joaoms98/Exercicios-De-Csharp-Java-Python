using System;
using crud_net_project.source.CrudNet.Domain.Commands.Requests;
using crud_net_project.source.CrudNet.Domain.Commands.Responses;
using crud_net_project.source.CrudNet.Domain.Handlers.Interfaces;

namespace crud_net_project.source.CrudNet.Domain.Handlers
{
    public class CreateUserHandler : ICreateUserHandler
    {
        public CreateUserResponse Handle(CreateUserRequest request)
        {
            //Verify if: user is already signed in
            //Validate data
            //Inserts user
            //Sends "Welcome" email

            return new CreateUserResponse
            {
                Id = Guid.NewGuid(),
                Name = "Name",
                Email = "email@email.com",
                Date = DateTime.UtcNow
            };
        }
    }
}