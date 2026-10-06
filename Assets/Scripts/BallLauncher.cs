using UnityEngine;

public class BallLauncher : MonoBehaviour
{
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float launchPower = 2f;

    public void LaunchBall()
    {
        if (ballPrefab == null)
        {
            Debug.LogError("Ball Prefab‚ªİ’è‚³‚ê‚Ä‚¢‚Ü‚¹‚ñI");
            return;
        }

        if (spawnPoint == null)
        {
            Debug.LogError("Spawn Point‚ªİ’è‚³‚ê‚Ä‚¢‚Ü‚¹‚ñI");
            return;
        }

        GameObject ball = Instantiate(
            ballPrefab,
            spawnPoint.position,
            Quaternion.identity
        );

        Rigidbody2D rb = ball.GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            rb.linearVelocity = Vector2.down * launchPower;
        }
    }
}