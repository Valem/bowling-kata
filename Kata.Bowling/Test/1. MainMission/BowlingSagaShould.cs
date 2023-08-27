using Shouldly;
using Xunit.Abstractions;
using Game = Kata.Bowling.Code._1._MainMission.Game;

namespace Kata.Bowling.Test._1._MainMission
{
    public class BowlingSagaShould
    {
        /*
         * Test your spells using TDD approach.
         */

        private readonly ITestOutputHelper _outputHelper;
        private readonly Game _game;

        public BowlingSagaShould(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
            _game = new Game();
        }

        [Fact]
        public void Score_WhenGutterGame_ShouldReturnZero()
        {
            // Arrange
            RollMany(20, 0);

            // Act
            var score = _game.Score();

            // Assert
            score.ShouldBe(0);
        }

        [Fact]
        public void Score_WhenOnePinIsKnockedDownOnEachRoll_ShouldReturn20()
        {
            // Arrange
            RollMany(20, 1);

            // Act
            var score = _game.Score();

            // Assert
            score.ShouldBe(20);
        }

        [Fact]
        public void Score_WhenAllStrikes_ShouldReturn300()
        {
            // Arrange
            RollMany(12, 10);

            // Act
            var score = _game.Score();

            // Assert
            score.ShouldBe(300);
        }

        [Fact]
        public void Score_ShouldAccountForOneSpare()
        {
            // Arrange
            _game.Roll(5);
            _game.Roll(5);  // Spare
            _game.Roll(3);
            RollMany(17, 0);

            // Act
            var score = _game.Score();

            // Assert
            score.ShouldBe(16);
        }

        [Fact]
        public void Score_ShouldAccountForOneStrike()
        {
            // Arrange
            _game.Roll(10);  // Strike
            _game.Roll(3);
            _game.Roll(4);
            RollMany(16, 0);

            // Act
            var score = _game.Score();

            // Assert
            score.ShouldBe(24);
        }

        private void RollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
            {
                _game.Roll(pins);
            }
        }
    }
}