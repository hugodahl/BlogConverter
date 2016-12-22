using System;
namespace BlogConverter.Formats.Intermediate
{

  public sealed class AuthorClassAttribute : BaseBlogSystemClassAttribute
  {
    public AuthorClassAttribute(string positionalString) : base(positionalString)
    {
    }
  }

}
