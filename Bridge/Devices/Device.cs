
namespace Bridge.Devices
{
  public abstract class Device
  {
    public abstract void TogglePower();
    public int Volume { get; set; }
    public int Channel { get; set; }
  }
}