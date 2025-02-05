using vm.MochiCore.Domain.Abstractions;

namespace vm.MochiCore.Domain.Exception.Email;

public static class EmailErrors
{
    public static Error NullOrEmpty => new("Email.NullOrEmpty", "The email is required.");

    public static Error LongerThanAllowed => new("Email.LongerThanAllowed", "The email is longer than allowed.");

    public static Error InvalidFormat => new("Email.InvalidFormat", "The email format is invalid.");
}