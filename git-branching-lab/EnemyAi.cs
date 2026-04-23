public class EnemyAi
{
    public float DetectionRadius = 0f;
    public float PatrolSpeed = 0f;

    public void Patrol()
    {
        Console.WriteLine($"Patrolling at speed {PatrolSpeed}");
    }
}