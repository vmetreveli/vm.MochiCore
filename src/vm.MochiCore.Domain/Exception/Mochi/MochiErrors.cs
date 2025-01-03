using vm.MochiCore.Domain.Abstractions;

namespace vm.MochiCore.Domain.Exception.Mochi;

public static class MochiErrors
{
    public static Error NullOrEmpty => new("Mochi.NullOrEmpty", "The mochi is required.");
    public static Error Duplicate(string name) => new("Mochi.Duplicate", $"The Mochi Name: '{name}' already exists.");
    
    public static class Description
    {
        // ReSharper disable once MemberHidesStaticFromOuterClass
        public static Error NullOrEmpty => new("Description.NullOrEmpty", "The description is required.");
    }

    public static class Amount
    {
        // ReSharper disable once MemberHidesStaticFromOuterClass
        public static  Error NullOrEmpty => new("Amount.NullOrEmpty", "The amount is required.");
    }
}