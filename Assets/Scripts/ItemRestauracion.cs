using UnityEngine;

public class ItemRestauracion : MonoBehaviour
{
    public FieldOfView fov; // Se asigna en el Inspector
    public float visionRestaurada = 8f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Colisi�n detectada con: " + collision.gameObject.name);

        if (collision.CompareTag("Player") && fov != null)
        {
            Debug.Log("Se restaur� la visi�n");
            fov.RestaurarVision(visionRestaurada);
            Destroy(gameObject);
        }
        else if (fov == null)
        {
            Debug.LogError("El objeto 'FOV' no est� asignado en el Inspector.");
        }
    }
}