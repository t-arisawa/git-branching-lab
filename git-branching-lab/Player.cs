public class Player
{
    // TODO: branches will replace these 0 placeholders
    public float MoveSpeed = 999f;
    public float JumpForce = 999f;

    public void Move(float horizontal)
    {
        Console.WriteLine($"Moving at speed {MoveSpeed}, input: {horizontal}");
    }
}