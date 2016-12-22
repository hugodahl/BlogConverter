using System;
namespace BlogConverter.Formats.Intermediate
{

  public sealed class CategoryClassAttribute : BaseBlogSystemClassAttribute
  {
    public CategoryClassAttribute(string positionalString) : base(positionalString)
    {
      this.positionalString = positionalString;
    }
  }

}
