using UnityEngine;

public class fail : MonoBehaviour
{
    public float launchForce = 1000f; // Fuerza con la que el jugador ser� lanzado

    void OnCollisionEnter(Collision collision)
    {
        // Verifica si el objeto con el que colision� tiene el tag "car"
        if (collision.gameObject.CompareTag("Car"))
        {
            // Obt�n el Rigidbody del jugador
            Rigidbody rb = GetComponent<Rigidbody>();

            if (rb != null)
            {
                // Aplica una fuerza hacia arriba
                rb.AddForce(Vector3.up * launchForce);
            }
        }
    }
}

