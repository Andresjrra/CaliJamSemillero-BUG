using UnityEngine;

public class MovPlayer : MonoBehaviour
{

    public FieldOfView fov;


    public float speed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GameObject fovObject = GameObject.Find("FOV"); // Buscar el objeto "FOV"
        if (fovObject != null)
        {
            fov = fovObject.GetComponent<FieldOfView>();
        }

        if (fov == null)
        {
            Debug.LogError("No se encontró el objeto 'FOV' con FieldOfView.");
        }
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        fov.SetOrigin(transform.position);
    }

    void FixedUpdate()
    {
        rb.linearVelocity = movement.normalized * speed;
    }
}