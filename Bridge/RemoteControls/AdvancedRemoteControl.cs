using Bridge.Devices;

namespace Bridge.RemoteControls
{
  public class AdvancedRemoteControl: RemoteControl
  {
    public AdvancedRemoteControl(Device device): base(device)
    {
        
    }

    void Mute(){
      device.Volume = 0;
    }
  }
}