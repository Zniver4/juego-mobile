using UnityEngine;

public class ProximityPoints : MonoBehaviour
{
    public Transform player;
    public float detectionRadius = 5f;
    public int points = 10;
    private bool pointsAwarded = false;

    void Update()
    {
        float distance = Vector3.Distance(player.position, transform.position);
        if (distance <= detectionRadius && !pointsAwarded)
        {
            ScoreManager.instance.AddPoints(points);
            pointsAwarded = true;
        }
    }
}

