﻿using MediatR;

namespace JwtApp.Application.Features.CQRS.Commands
{
    public class RegisterUserCommandRequest : IRequest
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}
