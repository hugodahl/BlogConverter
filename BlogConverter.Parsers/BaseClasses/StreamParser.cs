using System;
namespace BlogConverter.Parsers
{

  public abstract class StreamParser<T1, T2> : BaseParser<T1, T2>
  {
    protected StreamParser()
    {
      throw new NotImplementedException();
    }
  }

}
