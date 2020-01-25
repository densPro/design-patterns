using System;
using Bridge.Devices;
using Bridge.RemoteControls;

namespace Bridge
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("############## Universal Control ###############");
      Console.WriteLine(" TV ");
      Device device = new TV();
      Console.WriteLine($"Volume : {device.Volume}");
      RemoteControl remoteControl = new AdvancedRemoteControl(device);
      remoteControl.VolumeUp();
      Console.WriteLine($"Volume changed: {device.Volume}");
      remoteControl.TogglePower();

      Console.WriteLine(" Radio ");
      device = new Radio();
      Console.WriteLine($"Volume : {device.Volume}");
      remoteControl = new AdvancedRemoteControl(device);
      remoteControl.VolumeUp();
      Console.WriteLine($"Volume changed: {device.Volume}");
      remoteControl.TogglePower();

    }
  }
}
