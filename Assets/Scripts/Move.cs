using UnityEngine;

public class Move : MonoBehaviour
{
   
    void Update()
    {
        // Mover el objeto hacia adelante en cada frame
        transform.position += new Vector3(0, 0, -2) * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Destroy"))
        {
            Destroy(gameObject);
        }

    }
}
