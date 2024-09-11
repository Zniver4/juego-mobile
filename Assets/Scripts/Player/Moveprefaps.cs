using UnityEngine;

public class Moveprefaps : MonoBehaviour
{
    private float velocidad = 20f;

    void Update()
    {
        float movimiento = velocidad * Time.deltaTime;
        transform.Translate(0, 0, movimiento);
    }
}

