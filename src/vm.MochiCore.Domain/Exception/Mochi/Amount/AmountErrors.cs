using vm.MochiCore.Domain.Abstractions;

namespace vm.MochiCore.Domain.Exception.Mochi.Amount;

public static class AmountErrors
{
    public static Error NullOrEmpty => new("Amount.NullOrEmpty", "The amount is required.");

}