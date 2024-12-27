using BuberDinner.Domain.User;

namespace BuberDinner.Application.Features.Authentication.Common;

public record AuthenticationResult(
    User User,
    string Token
);