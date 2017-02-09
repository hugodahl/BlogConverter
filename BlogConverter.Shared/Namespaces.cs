using System;
using System.Collections.Generic;

namespace BlogConverter.Shared.Common
{

  namespace CodeJedi.Common.Utils.XML
  {

    public static class Namespaces
    {

      public static class Formal
      {
        public static XMLNamespaceDefinition DublinCore = new XMLNamespaceDefinition()
        {
          CommonNamespacePrefix = "dc",
          NamespaceURI = "http://purl.org/dc/elements/1.1/",
          Version = new Version(1, 2),
          SpecificationURI = "",
        };

        public static XMLNamespaceDefinition WellFormedWeb = new XMLNamespaceDefinition()
        {
          CommonNamespacePrefix = "wfw",
          NamespaceURI = "http://wellformedweb.org/CommentAPI/",
          Version = new Version(1, 0),
          SpecificationURI = "",
        };

        public static XMLNamespaceDefinition OpenXMLMarkupCompatibility = new XMLNamespaceDefinition
        {
          CommonNamespacePrefix = "mc",
          NamespaceURI = "http://schemas.openxmlformats.org/markup-compatibility/2006",
          Version = new Version(2016, 0),
          SpecificationURI = "",
        };

        public static XMLNamespaceDefinition XMLSchema = new XMLNamespaceDefinition
        {
          CommonNamespacePrefix = "xs",
          NamespaceURI = "http://www.w3.org/2001/XMLSchema",
          Version = new Version(2001, 0),
          SpecificationURI = "",
        };

        public static XMLNamespaceDefinition CreativeCommons = new XMLNamespaceDefinition
        {
          CommonNamespacePrefix = "creativeCommons",
          NamespaceURI = "http://backend.userland.com/creativeCommonsRssModule",
          Version = new Version(0, 0),
          SpecificationURI = "",
        };

        public static XMLNamespaceDefinition TrackBack = new XMLNamespaceDefinition
        {
          CommonNamespacePrefix = "trackback",
          NamespaceURI = "http://madskills.com/public/xml/rss/module/trackback/",
          Version = new Version(0, 0),
          SpecificationURI = "",
        };



      }

      public class Collections
      {
        public sealed class RSS : XMLNamespaceDefinitionCollection
        {
          private RSS() { } // Do not let it be instantiatable

          protected override IEnumerable<XMLNamespaceDefinition> IncludedNamespaces
          {
            get { return new[] { Formal.CreativeCommons, Formal.TrackBack }; }
          }

        }


        public sealed class WordPressWXR : XMLNamespaceDefinitionCollection
        {
          private WordPressWXR() { } // Do not let it be instantiable

          protected override IEnumerable<XMLNamespaceDefinition> IncludedNamespaces
          {
            get
            {
              return new[] { Formal.DublinCore, Formal.WellFormedWeb, Formal.XMLSchema };
            }

          }


        }

        public static class ShortNames
        {
          public static XMLNamespaceDefinition MC = Formal.OpenXMLMarkupCompatibility;
          public static XMLNamespaceDefinition WFW = Formal.WellFormedWeb;
          public static XMLNamespaceDefinition XS = Formal.XMLSchema;
          public static XMLNamespaceDefinition DC = Formal.DublinCore;
        }

      }

    }
  }
}
