using System;
namespace BlogConverter.Parsers
{

  public abstract class FileParser<T1, T2> : BaseParser<T1, T2>
  {
    public string FilePath { get; private set; }

    protected FileParser(string path) : this()
    {
      this.FilePath = path;
    }

    private FileParser()
    {
      throw new NotImplementedException();
    }
  }

}
