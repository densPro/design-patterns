using System.Collections.Generic;

namespace Proxy
{
  public class YouTubeManager
  {
    private IThirdPartyYouTubeLib _service;

    public YouTubeManager(IThirdPartyYouTubeLib service)
    {
      _service = service;
    }

    public Video RenderVideoPage(int id)
    {
      return _service.GetVideoInfo(id);
    }

    public Video DownloadVideo(int id)
    {
      return _service.DownloadVideo(id);
    }

    public IEnumerable<Video> RenderListPanel()
    {
      return _service.GetVideos();
    }
  }
}