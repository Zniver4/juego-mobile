using UnityEngine;

public class ZonaPerdida : MonoBehaviour
{
    public GameObject canvasPerdido; // Asigna el canvas desde el editor
    public GameObject canvasPausa; // Asigna el canvas de pausa desde el editor

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canvasPerdido.SetActive(true); // Activa el canvas de perdido
            canvasPausa.SetActive(false); // Desactiva el canvas de pausa
            Time.timeScale = 0; // Pausa el juego
        }
    }
}

