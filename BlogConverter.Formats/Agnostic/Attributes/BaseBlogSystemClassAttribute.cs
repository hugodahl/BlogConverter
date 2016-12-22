using System;
namespace BlogConverter.Formats.Intermediate
{

  [System.AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
  public class BaseBlogSystemClassAttribute : Attribute
  {
    readonly string positionalString;
    public string PositionalString
    {
      get
      {
        return positionalString;
      }
    }

    public int NamedInt { get; set; }

    public BaseBlogSystemClassAttribute(string positionalString)
    {
      this.positionalString = positionalString;

      this.DoInitialization();
    }

    private void DoInitialization()
    {
      // Do build-up stuff here

      // Let the descendant class do additional work
      this.OnInitialize();
    }

    /// <summary>
    /// Method invoked during the instantiation of the class, so that any descendant
    /// class execute any additional initialization code, if necessary.
    /// This is equivalent to having code within the constructor of the descendant class.
    /// </summary>
    protected virtual void OnInitialize()
    {

    }

  }

}
