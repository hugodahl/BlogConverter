// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

// 
//This source code was auto-generated by MonoXSD
//
namespace BlogConverter.BlogML.Native
{


  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
#if INCLUDE_SERIALIZABLE
  [System.SerializableAttribute()]
#endif
#if INCLUDE_DESIGNER_CATEGORY
  [System.ComponentModel.DesignerCategoryAttribute("code")]
#endif
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute("blogType", Namespace = "http://www.blogml.com/2006/09/BlogML")]
  [System.Xml.Serialization.XmlRootAttribute("blog", Namespace = "http://www.blogml.com/2006/09/BlogML", IsNullable = false)]
  public partial class Blog
  {

    private Title _title;

    private Title _subTitle;

    private Author[] _authors;

    private ExtendedProperty[] _extendedProperties;

    private Category[] _categories;

    private Post[] _posts;

    private System.DateTime _dateCreated;

    private bool _dateCreatedSpecified;

    private string _rootURL;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement("title")]
    public Title Title
    {
      get
      {
        return this._title;
      }
      set
      {
        this._title = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("sub-title")]
    public Title SubTitle
    {
      get
      {
        return this._subTitle;
      }
      set
      {
        this._subTitle = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray("authors")]
    [System.Xml.Serialization.XmlArrayItemAttribute("author", IsNullable = false)]
    public Author[] Authors
    {
      get
      {
        return this._authors;
      }
      set
      {
        this._authors = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute("extended-properties")]
    [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable = false)]
    public ExtendedProperty[] ExtendedProperties
    {
      get
      {
        return this._extendedProperties;
      }
      set
      {
        this._extendedProperties = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray("categories")]
    [System.Xml.Serialization.XmlArrayItemAttribute("category", IsNullable = false)]
    public Category[] Categories
    {
      get
      {
        return this._categories;
      }
      set
      {
        this._categories = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray("posts")]
    [System.Xml.Serialization.XmlArrayItemAttribute("post", IsNullable = false)]
    public Post[] Posts
    {
      get
      {
        return this._posts;
      }
      set
      {
        this._posts = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("date-created")]
    public System.DateTime DateCreated
    {
      get
      {
        return this._dateCreated;
      }
      set
      {
        this._dateCreated = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DateCreatedSpecified
    {
      get
      {
        return this._dateCreatedSpecified;
      }
      set
      {
        this._dateCreatedSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("root-url")]
    public string RootURL
    {
      get
      {
        return this._rootURL;
      }
      set
      {
        this._rootURL = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
#if INCLUDE_SERIALIZABLE
  [System.SerializableAttribute()]
#endif
#if INCLUDE_DESIGNER_CATEGORY
  [System.ComponentModel.DesignerCategoryAttribute("code")]
#endif
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute("titleType", Namespace = "http://www.blogml.com/2006/09/BlogML")]
  public partial class Title
  {

    private ContentTypes _type;

    private string[] textField;

    public Title()
    {
      this._type = ContentTypes.Text;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("type")]
    [System.ComponentModel.DefaultValueAttribute(ContentTypes.Text)]
    public ContentTypes Type
    {
      get
      {
        return this._type;
      }
      set
      {
        this._type = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] Text
    {
      get
      {
        return this.textField;
      }
      set
      {
        this.textField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
#if INCLUDE_SERIALIZABLE
  [System.SerializableAttribute()]
#endif
  [System.Xml.Serialization.XmlTypeAttribute("contentTypes", Namespace = "http://www.blogml.com/2006/09/BlogML")]
  public enum ContentTypes
  {

    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("html")]
    HTML,

    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("xhtml")]
    XHTML,

    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("text")]
    Text,

    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("base64")]
    Base64,
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
#if INCLUDE_SERIALIZABLE
  [System.SerializableAttribute()]
#endif
#if INCLUDE_DESIGNER_CATEGORY
  [System.ComponentModel.DesignerCategoryAttribute("code")]
#endif
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute("extendedpropertyType", Namespace = "http://www.blogml.com/2006/09/BlogML")]
  public partial class ExtendedProperty
  {

    private string _name;

    private string _value;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("name")]
    public string Name
    {
      get
      {
        return this._name;
      }
      set
      {
        this._name = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("value")]
    public string Value
    {
      get
      {
        return this._value;
      }
      set
      {
        this._value = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
#if INCLUDE_SERIALIZABLE
  [System.SerializableAttribute()]
#endif
#if INCLUDE_DESIGNER_CATEGORY
  [System.ComponentModel.DesignerCategoryAttribute("code")]
#endif
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute("authorRefType", Namespace = "http://www.blogml.com/2006/09/BlogML")]
  public partial class AuthorReference
  {

    private string _ref;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("ref")]
    public string Reference
    {
      get
      {
        return this._ref;
      }
      set
      {
        this._ref = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
#if INCLUDE_SERIALIZABLE
  [System.SerializableAttribute()]
#endif
#if INCLUDE_DESIGNER_CATEGORY
  [System.ComponentModel.DesignerCategoryAttribute("code")]
#endif
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute("authorsRefType", Namespace = "http://www.blogml.com/2006/09/BlogML")]
  public partial class AuthorsReference
  {

    private AuthorReference _author;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement("author")]
    public AuthorReference Author
    {
      get
      {
        return this._author;
      }
      set
      {
        this._author = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
#if INCLUDE_SERIALIZABLE
  [System.SerializableAttribute()]
#endif
#if INCLUDE_DESIGNER_CATEGORY
  [System.ComponentModel.DesignerCategoryAttribute("code")]
#endif
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute("attachmentType", Namespace = "http://www.blogml.com/2006/09/BlogML")]
  public partial class Attachment
  {

    private bool _embedded;

    private string _mimeType;

    private double _size;

    private bool _sizeFieldSpecified;

    private string _exernalURI;

    private string _url;

    private string _value;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("embedded")]
    public bool Embedded
    {
      get
      {
        return this._embedded;
      }
      set
      {
        this._embedded = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("mime-type")]
    public string MimeType
    {
      get
      {
        return this._mimeType;
      }
      set
      {
        this._mimeType = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("size")]
    public double Size
    {
      get
      {
        return this._size;
      }
      set
      {
        this._size = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sizeSpecified
    {
      get
      {
        return this._sizeFieldSpecified;
      }
      set
      {
        this._sizeFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("external-uri")]
    public string ExternalURI
    {
      get
      {
        return this._exernalURI;
      }
      set
      {
        this._exernalURI = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("url")]
    public string URL
    {
      get
      {
        return this._url;
      }
      set
      {
        this._url = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
      get
      {
        return this._value;
      }
      set
      {
        this._value = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
#if INCLUDE_SERIALIZABLE
  [System.SerializableAttribute()]
#endif
#if INCLUDE_DESIGNER_CATEGORY
  [System.ComponentModel.DesignerCategoryAttribute("code")]
#endif
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute("categoryRefType", Namespace = "http://www.blogml.com/2006/09/BlogML")]
  public partial class CategoryReference
  {

    private string _ref;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("ref")]
    public string Reference
    {
      get
      {
        return this._ref;
      }
      set
      {
        this._ref = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
#if INCLUDE_SERIALIZABLE
  [System.SerializableAttribute()]
#endif
#if INCLUDE_DESIGNER_CATEGORY
  [System.ComponentModel.DesignerCategoryAttribute("code")]
#endif
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute("contentType", Namespace = "http://www.blogml.com/2006/09/BlogML")]
  public partial class Content
  {

    private ContentTypes _type;

    private string _value;

    public Content()
    {
      this._type = ContentTypes.Text;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("type")]
    [System.ComponentModel.DefaultValueAttribute(ContentTypes.Text)]
    public ContentTypes ContentType
    {
      get
      {
        return this._type;
      }
      set
      {
        this._type = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
      get
      {
        return this._value;
      }
      set
      {
        this._value = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Author))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Category))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(TrackBack))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Comment))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Post))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
#if INCLUDE_SERIALIZABLE
  [System.SerializableAttribute()]
#endif
#if INCLUDE_DESIGNER_CATEGORY
  [System.ComponentModel.DesignerCategoryAttribute("code")]
#endif
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute("nodeType", Namespace = "http://www.blogml.com/2006/09/BlogML")]
  public partial class Node
  {

    private Title _title;

    private string _id;

    private System.DateTime _dateCreated;

    private bool _dateCreatedSpecified;

    private System.DateTime _dateModified;

    private bool _dateModifiedSpecified;

    private bool _approved;

    public Node()
    {
      this._approved = true;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement("type", typeof(Title))]
    public Title title
    {
      get
      {
        return this._title;
      }
      set
      {
        this._title = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("id")]
    public string ID
    {
      get
      {
        return this._id;
      }
      set
      {
        this._id = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("date-created")]
    public System.DateTime DateCreated
    {
      get
      {
        return this._dateCreated;
      }
      set
      {
        this._dateCreated = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool datecreatedSpecified
    {
      get
      {
        return this._dateCreatedSpecified;
      }
      set
      {
        this._dateCreatedSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("date-modified")]
    public System.DateTime DateModified
    {
      get
      {
        return this._dateModified;
      }
      set
      {
        this._dateModified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool datemodifiedSpecified
    {
      get
      {
        return this._dateModifiedSpecified;
      }
      set
      {
        this._dateModifiedSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("approved")]
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool Approved
    {
      get
      {
        return this._approved;
      }
      set
      {
        this._approved = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
#if INCLUDE_SERIALIZABLE
  [System.SerializableAttribute()]
#endif
#if INCLUDE_DESIGNER_CATEGORY
  [System.ComponentModel.DesignerCategoryAttribute("code")]
#endif
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute("authorType", Namespace = "http://www.blogml.com/2006/09/BlogML")]
  public partial class Author : Node
  {

    private string _email;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("email")]
    public string Email
    {
      get
      {
        return this._email;
      }
      set
      {
        this._email = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
#if INCLUDE_SERIALIZABLE
  [System.SerializableAttribute()]
#endif
#if INCLUDE_DESIGNER_CATEGORY
  [System.ComponentModel.DesignerCategoryAttribute("code")]
#endif
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute("categoryType", Namespace = "http://www.blogml.com/2006/09/BlogML")]
  public partial class Category : Node
  {

    private string _parentRef;

    private string _description;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("parentref")]
    public string ParentRef
    {
      get
      {
        return this._parentRef;
      }
      set
      {
        this._parentRef = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("description")]
    public string Description
    {
      get
      {
        return this._description;
      }
      set
      {
        this._description = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
#if INCLUDE_SERIALIZABLE
  [System.SerializableAttribute()]
#endif
#if INCLUDE_DESIGNER_CATEGORY
  [System.ComponentModel.DesignerCategoryAttribute("code")]
#endif
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute("tackbackType", Namespace = "http://www.blogml.com/2006/09/BlogML")]
  public partial class TrackBack : Node
  {

    private string _url;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("url")]
    public string URL
    {
      get
      {
        return this._url;
      }
      set
      {
        this._url = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
#if INCLUDE_SERIALIZABLE
  [System.SerializableAttribute()]
#endif
#if INCLUDE_DESIGNER_CATEGORY
  [System.ComponentModel.DesignerCategoryAttribute("code")]
#endif
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute("commentType", Namespace = "http://www.blogml.com/2006/09/BlogML")]
  public partial class Comment : Node
  {

    private Content _content;

    private string _username;

    private string _userEmail;

    private string _userURL;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement("content", typeof(Content))]
    public Content Content
    {
      get
      {
        return this._content;
      }
      set
      {
        this._content = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("user-name")]
    public string Username
    {
      get
      {
        return this._username;
      }
      set
      {
        this._username = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("user-email")]
    public string UserEmail
    {
      get
      {
        return this._userEmail;
      }
      set
      {
        this._userEmail = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("user-url")]
    public string UserURL
    {
      get
      {
        return this._userURL;
      }
      set
      {
        this._userURL = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
#if INCLUDE_SERIALIZABLE
  [System.SerializableAttribute()]
#endif
#if INCLUDE_DESIGNER_CATEGORY
  [System.ComponentModel.DesignerCategoryAttribute("code")]
#endif
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute("postType", Namespace = "http://www.blogml.com/2006/09/BlogML")]
  public partial class Post : Node
  {

    private Content _content;

    private Title _postName;

    private Content _excerpt;

    private CategoryReference[] _categories;

    private Comment[] _comments;

    private TrackBack[] _trackbacks;

    private Attachment[] _attachments;

    private AuthorsReference _authors;

    private string _postURL;

    private BlogPostTypes _postType;

    private bool _postTypeSpecified;

    private bool _hasExcerpt;

    private bool _hasExcerptSpecified;

    private string _views;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement("content", typeof(Content))]
    public Content content
    {
      get
      {
        return this._content;
      }
      set
      {
        this._content = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("post-name", typeof(Title))]
    public Title PostName
    {
      get
      {
        return this._postName;
      }
      set
      {
        this._postName = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement("excerpt", typeof(Content))]
    public Content excerpt
    {
      get
      {
        return this._excerpt;
      }
      set
      {
        this._excerpt = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray("categories")]
    [System.Xml.Serialization.XmlArrayItemAttribute("category", typeof(CategoryReference), IsNullable = false)]
    public CategoryReference[] Categories
    {
      get
      {
        return this._categories;
      }
      set
      {
        this._categories = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray("comments")]
    [System.Xml.Serialization.XmlArrayItemAttribute("comment", IsNullable = false)]
    public Comment[] Comments
    {
      get
      {
        return this._comments;
      }
      set
      {
        this._comments = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray("trackbacks")]
    [System.Xml.Serialization.XmlArrayItemAttribute("trackback", IsNullable = false)]
    public TrackBack[] TrackBacks
    {
      get
      {
        return this._trackbacks;
      }
      set
      {
        this._trackbacks = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray("attachments")]
    [System.Xml.Serialization.XmlArrayItemAttribute("attachment", IsNullable = false)]
    public Attachment[] Attachments
    {
      get
      {
        return this._attachments;
      }
      set
      {
        this._attachments = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement("authors", typeof(AuthorsReference))]
    public AuthorsReference authors
    {
      get
      {
        return this._authors;
      }
      set
      {
        this._authors = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("post-url")]
    public string PostURL
    {
      get
      {
        return this._postURL;
      }
      set
      {
        this._postURL = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("type", typeof(BlogPostTypes))]
    public BlogPostTypes PostType
    {
      get
      {
        return this._postType;
      }
      set
      {
        this._postType = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool typeSpecified
    {
      get
      {
        return this._postTypeSpecified;
      }
      set
      {
        this._postTypeSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("hasexcerpt", typeof(bool))]
    public bool HasExcerpt
    {
      get
      {
        return this._hasExcerpt;
      }
      set
      {
        this._hasExcerpt = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool hasexcerptSpecified
    {
      get
      {
        return this._hasExcerptSpecified;
      }
      set
      {
        this._hasExcerptSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("views", typeof(string))]
    public string Views
    {
      get
      {
        return this._views;
      }
      set
      {
        this._views = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
#if INCLUDE_SERIALIZABLE
  [System.SerializableAttribute()]
#endif
  [System.Xml.Serialization.XmlTypeAttribute("blogpostTypes", Namespace = "http://www.blogml.com/2006/09/BlogML")]
  public enum BlogPostTypes
  {

    /// <remarks/>
    [System.Xml.Serialization.XmlEnum("normal")]
    Normal,

    /// <remarks/>
    [System.Xml.Serialization.XmlEnum("article")]
    Article,
  }
}