using OOPractice;
using Xunit;

namespace OOPracticeTest
{
  public class DriverTest
  {
    [Fact]
    public void Should_return_car_message_when_drive_given_car_with_name_speed()
    {
      // given
      var car = new Car("Cool Car", 30);
      var driver = new Driver(car);

      // when
      string message = driver.Drive();

      // then
      Assert.Equal("Cool Car: speed up 30 km/h", message);
    }

    [Fact]
    public void Should_return_truck_message_when_drive_given_truck_with_name_speed()
    {
      // given
      var truck = new Truck("Big Truck", 10);
      var driver = new Driver(truck);

      // when
      string message = driver.Drive();

      // then
      Assert.Equal("Big Truck: speed up 10 km/h", message);
    }
  }
}
