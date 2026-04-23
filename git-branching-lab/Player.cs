public class Player
{
    // TODO: branches will replace these 0 placeholders
    public float MoveSpeed = 5f;
    public float JumpForce = 8f;

    public void Move(float horizontal)
    {
        Console.WriteLine($"Moving at speed {MoveSpeed}, input: {horizontal}");
    }
}