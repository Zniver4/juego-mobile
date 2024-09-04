using UnityEngine;

public class ZonaPerdida : MonoBehaviour
{
    public GameObject canvasPerdido; // Asigna el canvas desde el editor

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canvasPerdido.SetActive(true); // Activa el canvas
            Time.timeScale = 0; // Pausa el juego
        }
    }
}
