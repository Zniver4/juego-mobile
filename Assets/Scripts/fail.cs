using UnityEngine;

public class fail : MonoBehaviour
{
    public float launchForce = 1000f; // Fuerza con la que el jugador será lanzado

    void OnCollisionEnter(Collision collision)
    {
        // Verifica si el objeto con el que colisionó tiene el tag "car"
        if (collision.gameObject.CompareTag("Car"))
        {
            // Obtén el Rigidbody del jugador
            Rigidbody rb = GetComponent<Rigidbody>();

            if (rb != null)
            {
                // Aplica una fuerza hacia arriba
                rb.AddForce(Vector3.up * launchForce);
            }
        }
    }
}

