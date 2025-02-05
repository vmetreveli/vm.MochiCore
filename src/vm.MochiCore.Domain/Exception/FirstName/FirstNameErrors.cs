using vm.MochiCore.Domain.Abstractions;

namespace vm.MochiCore.Domain.Exception.FirstName;

public static class FirstNameErrors
{
    public static Error NullOrEmpty => new("Name.NullOrEmpty", "The name is required.");

    public static Error LongerThanAllowed => new("Name.LongerThanAllowed", "The name is longer than allowed.");
}