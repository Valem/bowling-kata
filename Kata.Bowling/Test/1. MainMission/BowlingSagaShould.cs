using Kata.Bowling.Code._1._MainMission;
using Xunit.Abstractions;

namespace Kata.Bowling.Test._1._MainMission
{
    public class BowlingSagaShould
    {
        /*
         * Test your spells using TDD approach.
         */

        private readonly ITestOutputHelper _outputHelper;

        public BowlingSagaShould(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Fact]
        public async Task TestFoo_Withxx_Expectxx()
        {
            // Arrange
            var testee = new Game();

            // Act
            //var result = await testee.DoIt();

            // Assert
            //result.ShouldNotBeNull();
        }
    }
}