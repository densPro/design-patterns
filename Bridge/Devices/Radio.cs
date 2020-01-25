namespace Bridge.Devices
{
  public class Radio : Device
  {
    private bool isOn;
     public Radio()
     {
         isOn = false;
     }
    public override void TogglePower()
    {
      isOn = !isOn;
      string togglePowerState = isOn? "on": "off";
      System.Console.WriteLine($"Turn radio {togglePowerState} and tune it to the 101 frequency by default");
    }
  }
}