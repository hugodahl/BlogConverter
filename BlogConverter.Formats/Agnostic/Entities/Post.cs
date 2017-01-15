using System;
using System.Collections.Generic;

namespace BlogConverter.Formats.Intermediate
{

  public abstract class BlogContent :  BaseBlogSystemEntity
  {
    public abstract string ContentType { get; }


    public int ID { get; private set; }
    public string Content { get; set; }
    public Author Author { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime PublihDate { get; set; }
    public string Slug { get; set; }
    public string URL { get; set; }

    public ContentStatus Status { get; set; }

    public List<Category> Categories { get; set; }
    public List<Tag> Tags { get; set; }

    public BlogContent()
    {
      this.Categories = new List<Category>();
      this.Tags = new List<Tag>();
    }

  }

  public sealed class Post : BlogContent
  {

    public override string ContentType => "Post";

  }




  public sealed class Comment: BaseBlogSystemEntity
  {
    public int ID { get; private set;}
    public int EntryID { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }
    public DateTime CommentDate { get; set; }
  }

  public enum ContentStatus
  {
    Draft,
    Published,
    Deleted
  }

}
