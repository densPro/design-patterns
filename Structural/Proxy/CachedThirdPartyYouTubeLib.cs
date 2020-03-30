using System.Collections.Generic;

namespace Proxy
{
  public class CachedThirdPartyYouTubeLib : IThirdPartyYouTubeLib
  {
    private ThirdPartyYouTubeLib _service;
    public Video DonwloadedVideoCache { get; private set; }
    public Video VideoInfoCache { get; private set; }
    public IEnumerable<Video> VideosCache { get; private set; }

    public CachedThirdPartyYouTubeLib(ThirdPartyYouTubeLib service)
    {
      _service = service;
    }
    public Video DownloadVideo(int id)
    {
      if (DonwloadedVideoCache == null)
      {
        DonwloadedVideoCache = _service.DownloadVideo(id);
      }

      return DonwloadedVideoCache;
    }

    public Video GetVideoInfo(int id)
    {
      if (VideoInfoCache == null)
      {
        VideoInfoCache = _service.GetVideoInfo(id);
      }

      return VideoInfoCache;
    }

    public IEnumerable<Video> GetVideos()
    {
      if (VideosCache == null)
      {
        VideosCache = _service.GetVideos();
      }

      return VideosCache;
    }
  }
}