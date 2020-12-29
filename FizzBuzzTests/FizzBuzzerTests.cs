using System;
using Xunit;
using FizzBuzz;

namespace FizzBuzzTests
{
    public class FizzBuzzerShould
    {
        [Fact]
        public void EnsureSolutionIsWiredCorrectly()
        {
            Assert.True(new FizzBuzzer().Test());
        }
    }
}
