using UnityEngine;

public class CarMove : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        // Mover el objeto hacia adelante
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
