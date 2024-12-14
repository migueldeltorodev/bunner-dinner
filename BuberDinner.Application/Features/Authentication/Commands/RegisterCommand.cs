using BuberDinner.Application.Features.Authentication.Common;
using ErrorOr;
using MediatR;

namespace BuberDinner.Application.Features.Authentication.Commands;

public record RegisterCommand(string FirstName, string LastName, string Email, string Password)
    : IRequest<ErrorOr<AuthenticationResult>>;