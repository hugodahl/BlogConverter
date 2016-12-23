using System;
namespace BlogConverter.Parsers
{

  public class WordPressWXR : XmlFileParser
  {
    
    public WordPressWXR(string path) : base(path)
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
