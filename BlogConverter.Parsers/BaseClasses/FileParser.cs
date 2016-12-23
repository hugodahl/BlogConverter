using System;
namespace BlogConverter.Parsers
{

  public abstract class FileParser<T1, T2> : BaseParser<T1, T2>
  {
    public string FilePath { get; private set; }

    public FileParser(string path) : this()
    {

    }

    private FileParser()
    {
      throw new NotImplementedException();
    }
  }

}
