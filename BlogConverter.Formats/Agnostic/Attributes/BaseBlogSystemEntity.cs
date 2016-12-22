using System;
using System.Collections.Generic;

namespace BlogConverter.Formats.Intermediate
{

 [System.Runtime.Serialization.DataContract]
  public abstract class BaseBlogSystemEntity
  {
    public Dictionary<string, object> UnmappedProperties { get; private set;}

    public BaseBlogSystemEntity()
    {
      this.UnmappedProperties = new Dictionary<string, object>();
    }

  }

}
