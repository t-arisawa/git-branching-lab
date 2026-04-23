public class Ui
{
    public float ScoreMultiplier = 1.6f;

    public void DisplayScore(int score)
    {
        Console.WriteLine($"Score: {score * ScoreMultiplier}");
    }
}