using System;
namespace BlogConverter.Connectors
{

  public abstract class BlogConnection : IDisposable
  {
    public bool IsConnected { get; private set; }

    public BlogConnector Connector { get; private set; }

    public abstract bool Disconnect();

    public abstract bool Reconnect();

    public BlogConnection(BlogConnector connector)
    {
      if (null == connector)
      {
        throw new ArgumentNullException(nameof(connector), "A BlogConnector instance must be specified and cannot be null.");
      }


      this.Connector = connector;
    }

    #region IDisposable Support
    private bool isDisposed = false; // To detect redundant calls

    protected virtual void Dispose(bool disposing)
    {
      if (!isDisposed)
      {
        if (disposing)
        {
          // TODO: dispose managed state (managed objects).
          this.Disconnect();
        }

        // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
        // TODO: set large fields to null.

        isDisposed = true;
      }
    }

    // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
    // ~BlogConnection() {
    //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
    //   Dispose(false);
    // }

    // This code added to correctly implement the disposable pattern.
    void IDisposable.Dispose()
    {
      // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
      this.Dispose(true);
      // TODO: uncomment the following line if the finalizer is overridden above.
      // GC.SuppressFinalize(this);
    }
    #endregion

  }

}
