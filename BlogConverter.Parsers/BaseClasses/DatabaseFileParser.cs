using System;
namespace BlogConverter.Parsers
{

  public abstract class DatabaseFileParser<T1, T2> : FileParser<T1, T2>
  {
    protected DatabaseFileParser(string path) : base(path)
    {
      throw new NotImplementedException();
    }
  }

}
