using UnityEngine;

public class playermovement : MonoBehaviour
{
    float horizontalMove = 0;
    public float runSpeedHorizontal = 5;
    public float runSpeed = 5;

    Rigidbody rigidbody;

    public Joystick joystick;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        horizontalMove = joystick.Horizontal * runSpeedHorizontal;

        transform.position += new Vector3(horizontalMove, 0, 0) * Time.deltaTime * runSpeed;
    }
}

