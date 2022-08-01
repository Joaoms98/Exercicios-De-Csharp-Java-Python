using System;

namespace crud_net_project.source.CrudNet.Domain.Commands.Responses
{
    public class CreateUserResponse
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }

        public string? Email { get; set; }

        public DateTime Date { get; set; }
    }
}