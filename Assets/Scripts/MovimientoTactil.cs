using UnityEngine;

public class MovimientoTactil : MonoBehaviour
{
    public float velocidad = 0.1f;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch toque = Input.GetTouch(0);

            if (toque.phase == TouchPhase.Moved)
            {
                Vector2 posicion = toque.deltaPosition;
                transform.Translate(posicion.x * velocidad * Time.deltaTime, 0, 0);
            }
        }
    }
}
