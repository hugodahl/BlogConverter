using System;
namespace BlogConverter.Connectors
{

  public abstract class BlogConnector
  {

    public abstract BlogConnection Connect();

    public abstract bool Validate();


  }

}
