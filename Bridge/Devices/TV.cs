namespace Bridge.Devices
{
  public class TV : Device
  {
    private bool isOn;
    public TV()
    {
      isOn = false;
    }

    public override void TogglePower()
    {
      isOn = !isOn;
      string togglePowerState = isOn ? "on" : "off";
      System.Console.WriteLine($"Turn tv {togglePowerState} and select 14 channel by default");
    }
  }
}