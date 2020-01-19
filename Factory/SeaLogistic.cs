namespace Factory
{
  class SeaLogistic : Logistic
  {
    public Transport CreateTransport()
    {
        return new Ship();
    }
  }
}