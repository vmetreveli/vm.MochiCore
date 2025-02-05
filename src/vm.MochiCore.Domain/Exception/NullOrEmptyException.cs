using Framework.Abstractions.Exceptions;

namespace vm.MochiCore.Domain.Exception;

public sealed class NullOrEmptyException(string message) : InflowException("NullOrEmpty", message);