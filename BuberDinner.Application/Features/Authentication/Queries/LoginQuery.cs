using BuberDinner.Application.Features.Authentication.Common;
using ErrorOr;
using MediatR;

namespace BuberDinner.Application.Features.Authentication.Queries;

public record LoginQuery(string Email, string Password)
    : IRequest<ErrorOr<AuthenticationResult>>;