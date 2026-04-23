public class Ui
{
    public float ScoreMultiplier = 0f;

    public void DisplayScore(int score)
    {
        Console.WriteLine($"Score: {score * ScoreMultiplier}");
    }
}