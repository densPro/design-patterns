using Bridge.Devices;

namespace Bridge.RemoteControls
{
  public class RemoteControl
  {
    protected Device device;

    public RemoteControl(Device device)
    {
      this.device = device;
    }

    public void TogglePower()
    {
      device.TogglePower();
    }

    public void VolumeDown()
    {
      device.Volume = device.Volume - 10;
    }

    public void VolumeUp()
    {
      device.Volume = device.Volume + 10;
    }

    public void ChannelDown()
    {
      device.Channel = device.Channel - 1;
    }

    public void ChannelUp()
    {
      device.Channel = device.Channel + 1;
    }
  }
}