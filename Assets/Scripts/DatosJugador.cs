using TMPro;
using UnityEngine;
using UnityEditor.PackageManager.Requests;

public class DatosJugador : MonoBehaviour
{
    
    public TextMeshProUGUI tiempoRestante;
    public float tiempo = 20f;

  
    void Update()
    {
        if (tiempo > 0)
        {
            tiempo -= Time.deltaTime;
            tiempoRestante.text = "" + Mathf.Ceil(tiempo).ToString();

        }
        else
        {
            tiempo = 0;
            tiempoRestante.text = "0";
        }
    }
}
