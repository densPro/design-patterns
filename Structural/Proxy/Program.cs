using System;

namespace Proxy
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("############ Third party Youtube library #############");
      var youTubeService = new ThirdPartyYouTubeLib();
      var youTubeServiceProxy = new CachedThirdPartyYouTubeLib(youTubeService);
      var manager = new YouTubeManager(youTubeServiceProxy);
      Console.WriteLine("Caching request to a third party library from youtube. (Lazy initialization)");

      Console.WriteLine("First time calling youtube service methods");

      var renderedvideo = manager.RenderVideoPage(1); // Id doesn't matter. Video has an auto incremental approach implemented
      Console.WriteLine($"Rendered Video Page: {renderedvideo.ToString()}");
      var donwloadedVideo = manager.DownloadVideo(1);
      Console.WriteLine($"Donwloaded Video: {donwloadedVideo.ToString()}");
      var videos = manager.RenderListPanel();
      foreach (var video in videos)
      {
        Console.WriteLine($"Rendered Video Page: {video.ToString()}");
      }

      Console.WriteLine("\nSecond time calling youtube service methods");

      var renderedvideo2 = manager.RenderVideoPage(1);
      Console.WriteLine($"Rendered Video Page: {renderedvideo2.ToString()}");
      var donwloadedVideo2 = manager.DownloadVideo(1);
      Console.WriteLine($"Donwloaded Video: {donwloadedVideo2.ToString()}");
      var videos2 = manager.RenderListPanel();
      foreach (var video in videos2)
      {
        Console.WriteLine($"Rendered Video Page: {video.ToString()}");
      }

      Console.WriteLine("\nVideo object should be instanciated just 3 times.");
      Console.WriteLine("Then youtube service uses only cached values");
      Console.WriteLine("Because these objects are cached");

    }
  }
}
