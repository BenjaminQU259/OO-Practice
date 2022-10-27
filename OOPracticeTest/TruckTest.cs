namespace OOPracticeTest
{
  using OOPractice;
  using Xunit;

  public class TruckTest
  {
    [Fact]
    public void Should_return_message_when_speed_up_given_truck_with_name_speed()
    {
      // given
      var truck = new Truck("Big Truck", 10);

      // when
      string message = truck.SpeedUp();

      // then
      Assert.Equal("Big Truck: speed up 10 km/h", message);
    }
  }
}
