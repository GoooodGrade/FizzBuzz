using FizzBuzz;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzGameTest
    {
        [Fact]
        public void Should_return_1_When_SpeakNumber_given_normal_case_number()
        {
            // Given
            int number = 1;

            // When
            FizzBuzzGame game = new FizzBuzzGame();
            string speakResult = game.SpeakNumber(number);

            // Then
            Assert.Equal("1", speakResult);
        }

        [Fact]
        public void Should_return_Fizz_When_number_given_3()
        {
            // Given
            int number = 3;

            // When
            FizzBuzzGame game = new FizzBuzzGame();
            string speakResult = game.SpeakNumber(number);

            // Then
            Assert.Equal("Fizz", speakResult);
        }

        [Fact]
        public void Should_return_Buzz_When_number_given_5()
        {
            // Given
            int number = 5;

            // When
            FizzBuzzGame game = new FizzBuzzGame();
            string speakResult = game.SpeakNumber(number);

            // Then
            Assert.Equal("Buzz", speakResult);
        }

        [Fact]
        public void Should_return_FizzBuzz_When_number_given_15()
        {
            //Given
            int number = 15;

            //When
            FizzBuzzGame game = new FizzBuzzGame();
            string speakResult = game.SpeakNumber(number);

            //then
            Assert.Equal("FizzBuzz", speakResult);
        }
    }
}