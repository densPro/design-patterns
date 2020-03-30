using System.Collections.Generic;

namespace Proxy
{
  public interface IThirdPartyYouTubeLib
  {
    IEnumerable<Video> GetVideos();
    Video GetVideoInfo(int id);
    Video DownloadVideo(int id);
  }
}