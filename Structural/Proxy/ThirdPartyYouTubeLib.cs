using System.Collections.Generic;

namespace Proxy
{
  public class ThirdPartyYouTubeLib : IThirdPartyYouTubeLib
  {
    public Video DownloadVideo(int id) => new Video();

    public Video GetVideoInfo(int id) => new Video();

    public IEnumerable<Video> GetVideos() => new List<Video>(){ new Video()};
  }
}