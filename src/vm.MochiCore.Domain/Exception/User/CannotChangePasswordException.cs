using Framework.Abstractions.Exceptions;
using Microsoft.Extensions.Logging;

namespace vm.MochiCore.Domain.Exception.User;

public class CannotChangePasswordException() 
    : InflowException("CannotChangePassword", "The password cannot be changed to the specified password.", null, LogLevel.Warning);