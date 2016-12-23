using System;
namespace BlogConverter.Parsers
{

  public abstract class FeedParser<T1 ,T2> : StreamParser<T1, T2>
  {
    public FeedParser()
    {
      throw new NotImplementedException();
    }
  }

}
