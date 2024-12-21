using vm.MochiCore.Domain.Abstractions;

namespace vm.MochiCore.Domain.Exception.Mochi.Description;

public static class DescriptionErrors
{
    public static Error NullOrEmpty => new("Description.NullOrEmpty", "The description is required.");

}