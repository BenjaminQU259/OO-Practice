namespace OOPractice
{
  public class Driver
  {
    private readonly Vehicle vehicle;

    public Driver(Vehicle vehicle)
    {
      this.vehicle = vehicle;
    }

    public string Drive()
    {
      return vehicle.SpeedUp();
    }
  }
}
