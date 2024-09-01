using UnityEngine;

public class Move : MonoBehaviour
{
    public float velocidad = 2f; // Velocidad de movimiento

    void Update()
    {
        // Mover el objeto hacia adelante en cada frame
        transform.position += new Vector3(0, 0, -velocidad) * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Destroy"))
        {
            Destroy(gameObject);
        }
    }
}
