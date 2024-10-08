using WindChill.Meteorology;

namespace TestMeteorology
{
    public class UnitTest1
    {
        [Fact]
        public void ConvertCelsiusToFahrenheit_Test()
        {
            // AAA pattern - vi opdeler, organisere og eksekverer vores tests.

            // Arrange
            double celcTempNow = 9;
            double windSpeedMS = 7;
            var testObj = new WindChillFactor(TemperatureScale.Scale.Celsius, WindSpeedUnit.Unit.MeterPerSecond, celcTempNow, windSpeedMS);
            double expectedResult = 48.2; 

            // Act
            double result = testObj.ConvertCelsiusToFahrenheit(celcTempNow); // 48.2F expected.

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}