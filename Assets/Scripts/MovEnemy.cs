using UnityEngine;

public class MovEnemy : MonoBehaviour
{
    public Transform player;  
    public float speed = 2f;  

    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  
    }

    void Update()
    {
        if (player != null)
        {
            Vector2 direction = (player.position - transform.position).normalized; 
            movement = direction;
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocity = movement * speed; 
    }
}
