namespace Proxy
{
  public class Video
  {
    public static int _incrementalId;

    public Video()
    {
      _incrementalId++;
    }

    public override string ToString() => $"number of videos instanciated : {_incrementalId}";
  }
}