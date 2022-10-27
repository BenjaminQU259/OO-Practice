using OOPractice;
using Xunit;

namespace OOPracticeTest
{
  public class CarTest
  {
    [Fact]
    public void Should_return_message_when_speed_up_given_car_with_name_speed()
    {
      // given
      var car = new Car("Cool Car", 30);

      // when
      string message = car.SpeedUp();

      // then
      Assert.Equal("Cool Car: speed up 30 km/h", message);
    }
  }
}
