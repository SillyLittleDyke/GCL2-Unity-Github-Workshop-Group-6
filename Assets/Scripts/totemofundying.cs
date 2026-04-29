using UnityEngine;

public class InstantDeathRespawn : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 startPos;   // Starting position used for respawn

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPos = transform.position;   // Save the original spawn point
    }

    // Only hazards will call this.

    public void Respawn()
    {
        rb.linearVelocity = Vector2.zero;
        transform.position = startPos;
    }
}
