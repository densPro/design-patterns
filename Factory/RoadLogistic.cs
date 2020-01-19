class RoadLogistic : Logistic
{
  public Transport CreateTransport()
  {
    return new Truck();
  }
}