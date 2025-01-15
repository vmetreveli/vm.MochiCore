using Framework.Abstractions.Exceptions;
using vm.MochiCore.Domain.Abstractions;

namespace vm.MochiCore.Domain.Exception.Mochi;

public class MochiException(string code, string title) : InflowException(code, title)
{
  public MochiException(Error error) : this(error.Code, error.Name)
  {
  }
}
