using UnityEngine;

public class AutoMoveForward : MonoBehaviour
{
    public float speed = 5f; // Velocidad de movimiento

    void Update()
    {
        // Mover el objeto hacia adelante en cada frame
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
