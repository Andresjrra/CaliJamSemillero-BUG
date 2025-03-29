using UnityEngine;
using UnityEngine.SceneManagement;

public class MovEnemy : MonoBehaviour
{
    public Transform player;
    public float speed = 2f;

    private Rigidbody2D rb;
    private Vector2 movement;

    private GameOverManager gameOverManager;
    private bool gameOverActivado = false; // Variable para evitar múltiples activaciones

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        gameOverManager = FindFirstObjectByType<GameOverManager>();
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
        rb.velocity = movement * speed; // Corregido: 'linearVelocity' no existe
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !gameOverActivado) 
        {
            gameOverActivado = true; // Evita múltiples activaciones
            gameOverManager.ActivarGameOverPanel();
            Debug.Log("Game Over Activado"); // Verifica en la consola si se llama correctamente
        }
    }
}