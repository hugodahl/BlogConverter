using System;
namespace BlogConverter.Formats.Intermediate
{

  public sealed class Media : BaseBlogSystemEntity
  {
    public string Source { get; set; }
    public string MimeType { get; set; }
    public string Filename { get; set; }
    public bool IsRetrieved => Status.IsSuccess;
    public RetrievalStatus Status { get; private set; }
    public byte[] Data { get; set; } 

    public Media()
    {
      Status = new RetrievalStatus();
    }
  }

  public sealed class RetrievalStatus
  {
    public RetrievalStatusCode StatusCode { get; set; }
    public string Message { get; set; }
    public bool IsSuccess => this.StatusCode == RetrievalStatusCode.Success;
  }


  public enum RetrievalStatusCode
  {
    Default = 0,
    InProgress = 1,
    Success = 2,
    Failed = 3,
    Other = 4,
  }

}
