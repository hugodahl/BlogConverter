using System;
namespace BlogConverter.Parsers
{
  public sealed class BlogMLParser : XmlFileParser
  {

    public BlogMLParser(string path) : base(path)
    {
    
    }

    protected override bool OnParse()
    {
      throw new NotImplementedException();
    }

    protected override bool OnValidateConfiguration()
    {
      throw new NotImplementedException();
    }

    protected override bool OnValidateSource()
    {
      throw new NotImplementedException();
    }

  }

}
