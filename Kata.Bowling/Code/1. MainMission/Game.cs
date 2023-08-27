namespace Kata.Bowling.Code._1._MainMission;

public class Game
{
    private readonly List<int> _rolls = new List<int>();

    public void Roll(int pins)
    {
        _rolls.Add(pins);
    }

    public int Score()
    {
        int score = 0;
        int frameIndex = 0;

        for (int frame = 0; frame < 10; frame++)
        {
            if (IsStrike(frameIndex))
            {
                score += 10 + StrikeBonus(frameIndex);
                frameIndex++;
            }
            else if (IsSpare(frameIndex))
            {
                score += 10 + SpareBonus(frameIndex);
                frameIndex += 2;
            }
            else
            {
                score += SumOfPinsInFrame(frameIndex);
                frameIndex += 2;
            }
        }

        return score;
    }

    private bool IsStrike(int frameIndex) => _rolls[frameIndex] == 10;

    private bool IsSpare(int frameIndex) => _rolls[frameIndex] + _rolls[frameIndex + 1] == 10;

    private int StrikeBonus(int frameIndex) => _rolls[frameIndex + 1] + _rolls[frameIndex + 2];

    private int SpareBonus(int frameIndex) => _rolls[frameIndex + 2];

    private int SumOfPinsInFrame(int frameIndex) => _rolls[frameIndex] + _rolls[frameIndex + 1];
}