public class EnemyAi
{
    public float DetectionRadius = 10f; // ← changed from 0f
    public float PatrolSpeed = 3f; // ← changed from 0f

    public void Patrol()
    {
        Console.WriteLine($"Patrolling at speed {PatrolSpeed}");
    }
}