using System;
using System.Collections.Generic;

namespace BlogConverter.Formats.Intermediate
{
  public class Blog : BaseBlogSystemEntity
  {
    public string Title { get; set;}
    public string SubTitle { get; set; }

    public string DomainName { get; set; }
    public string RelativePath { get; set; }

    public List<Author> Authors { get; private set;}
    public List<Post> Posts { get; private set;}
    public List<Category> Categories { get; private set;}
    public List<Page> Pages { get; private set; }
    public List<Tag> Tags { get; private set; }

    public List<string> MappedDomainNames { get; private set;}

    public Blog()
    {
      this.Authors = new List<Author>();
      this.Categories = new List<Category>();
      this.Posts = new List<Post>();
      this.Pages = new List<Page>();
      this.Tags = new List<Tag>();

      this.MappedDomainNames = new List<string>();
    }

    public Blog(string domainName, string relativePath = "/") : this()
    {
      this.DomainName = domainName;
      this.RelativePath = relativePath;
    }


  }


}
