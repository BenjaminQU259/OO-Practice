namespace OOPractice
{
  public class Driver
  {
    private Vehicle vehicle;

    public void Drive(Vehicle vehicle)
    {
      this.vehicle = vehicle;
    }

    public string SpeedUp()
    {
      return vehicle.SpeedUp();
    }
  }
}
