using System;
using System.Collections.Generic;

namespace BlogConverter.Shared.Common
{

  namespace CodeJedi.Common.Utils.XML
  {
    public class XMLNamespaceDefinition
    {
      public string NamespaceURI { get; internal set; }

      public string CommonNamespacePrefix { get; internal set; }

      public Version Version { get; internal set; }

      public string SpecificationURI { get; internal set; }

    }


    public abstract class XMLNamespaceDefinitionCollection
    {
      protected abstract IEnumerable<XMLNamespaceDefinition> IncludedNamespaces { get; }

      public virtual XMLNamespaceDefinition DefaultNamespace { get; }
      public string SpecificationURI { get; internal set; }
      public IEnumerable<XMLNamespaceDefinition> Namespaces { get { return this.IncludedNamespaces; } }
    }


  }
}
