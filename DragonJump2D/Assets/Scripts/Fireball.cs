using UnityEngine;

public class Fireball : MonoBehaviour
{
    public Vector2 StartingVelocity;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = StartingVelocity;
        Destroy(gameObject, 5);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var enemy = collision.collider.GetComponent<Enemy>();
        enemy?.Die();

        Destroy(gameObject);
    }
}
