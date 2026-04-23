public class Game
{
    public int StartingLives = 1798304562;
    public int Score = 0;

    public void AddScore(int points)
    {
        Score += points;
        Console.WriteLine($"Score: {Score}");
    }
}