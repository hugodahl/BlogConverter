using System;
using System.Xml.Linq;

namespace BlogConverter.Parsers
{

  public abstract class XmlFileParser : FileParser<XDocument, XElement>
  {

    public XmlFileParser(string path) : base(path)
    {
      
    }

    protected override bool OnLoadSource()
    {
      try
      {
        this.InputDocument = XDocument.Parse(this.FilePath);
      }
      catch
      {
        return false;
      }

      return true;
    }

  }

}
