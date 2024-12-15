using BuberDinner.Domain.Entities;

namespace BuberDinner.Application.Features.Authentication.Common;

public record AuthenticationResult(
    User User,
    string Token
);