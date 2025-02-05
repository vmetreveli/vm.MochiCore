using vm.MochiCore.Domain.Abstractions;

namespace vm.MochiCore.Domain.Exception.Authentication;

public static class AuthenticationErrors
{
    public static Error InvalidEmailOrPassword => new(
        "Authentication.InvalidEmailOrPassword",
        "The specified email or password are incorrect.");
}