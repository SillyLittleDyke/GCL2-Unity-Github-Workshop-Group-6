using UnityEngine;

public class EnemySlow : MonoBehaviour

{
    public Transform leftPoint;
    public Transform rightPoint;

    public float moveSpeed;

    private Rigidbody2D enemyRigidbody;

    public bool movingRight;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemyRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (movingRight && (transform.position.x > rightPoint.position.x))
        {
            movingRight = false;
        }

        if (!movingRight && (transform.position.x < leftPoint.position.x))
        {
            movingRight = true;
        }

        if (movingRight)
        {
            enemyRigidbody.linearVelocity = new Vector2(moveSpeed, enemyRigidbody.linearVelocity.y);
        }
        else
        {
            enemyRigidbody.linearVelocity = new Vector2(-moveSpeed, enemyRigidbody.linearVelocity.y);
        }
    }
}
