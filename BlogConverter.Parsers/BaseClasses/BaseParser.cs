using System;
using System.Collections.Generic;

namespace BlogConverter.Parsers
{

  public abstract class BaseParser<TInputDocumentType, TInputDocumentElementType>
  {
    /// <summary>
    /// Gets or sets the input document contents
    /// </summary>
    /// <value>The input document.</value>
    protected TInputDocumentType InputDocument { get; set; }

    /// <summary>
    /// Gets the individual elements of the input file (Posts, pages, etc)
    /// </summary>
    /// <value>The elements.</value>
    protected List<TInputDocumentType> Elements { get; private set;}

    /// <summary>
    /// Gets a value indicating whether the parser&apos; input source is valid.
    /// </summary>
    /// <value><c>true</c> if the input source is valid; otherwise, <c>false</c>.</value>
    protected bool IsSourceValid { get; private set; }

    /// <summary>
    /// Gets a value indicating whether the parser&apos; configuration is valid.
    /// </summary>
    /// <value><c>true</c> if is configuration value; otherwise, <c>false</c>.</value>
    protected bool IsConfigurationValue { get; private set;}

    /// <summary>
    /// Parse the input source of the parser
    /// </summary>
    /// <value><c>true</c> if the parsing operation was succesful; otherwise, <c>false</c>.</value>
    public bool Parse()
    {
      return this.OnParse();
    }

    /// <summary>
    /// Ons the parse.
    /// </summary>
    /// <returns><c>true</c>, if parse was oned, <c>false</c> otherwise.</returns>
    protected abstract bool OnParse();

    /// <summary>
    /// Loads the input source into the <seealso cref="InputDocument" />
    /// </summary>
    /// <returns><c>true</c>, if source was loaded, <c>false</c> otherwise.</returns>
    public bool LoadSource()
    {
      return this.OnLoadSource();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns><c>true</c>, if load source was oned, <c>false</c> otherwise.</returns>
    protected abstract bool OnLoadSource();

    /// <summary>
    /// Validates the source.
    /// </summary>
    /// <returns><c>true</c>, if source was validated, <c>false</c> otherwise.</returns>
    public bool ValidateSource()
    {
      return this.OnValidateSource();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns><c>true</c>, if validate source was oned, <c>false</c> otherwise.</returns>
    protected abstract bool OnValidateSource();

    /// <summary>
    /// Validates the configuration of the parser
    /// </summary>
    /// <returns><c>true</c>, if configuration was validated, <c>false</c> otherwise.</returns>
    public bool ValidateConfiguration()
    {
      return this.OnValidateConfiguration();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns><c>true</c>, if validate configuration was oned, <c>false</c> otherwise.</returns>
    protected abstract bool OnValidateConfiguration();

    /// <summary>
    /// Initializes a new instance of the <see cref="T:BlogConverter.Parsers.BaseParser`2"/> class.
    /// </summary>
    public  BaseParser()
    {
      this.Elements = new List<TInputDocumentType>();
    }

  }

}
