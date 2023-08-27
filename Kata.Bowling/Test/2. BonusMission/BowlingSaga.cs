using Xunit.Abstractions;

namespace Kata.Bowling.Test._2._BonusMission
{
    public class BowlingSaga
    {
        /*
         * Test your spells using TDD approach.
         */

        private readonly ITestOutputHelper _outputHelper;

        public BowlingSaga(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Fact]
        public async Task TestFoo_Withxx_Expectxx()
        {
            // Arrange
            var testee = new Code._2._BonusMission.Game();

            // Act
            //var result = await testee.DoIt();

            // Assert
            //result.ShouldNotBeNull();
        }
    }
}