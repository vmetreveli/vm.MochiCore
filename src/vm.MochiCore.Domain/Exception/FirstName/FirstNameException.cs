using Framework.Abstractions.Exceptions;

namespace vm.MochiCore.Domain.Exception.FirstName;

public class FirstNameException(string code, string message)
    : InflowException(code, message);