using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private Variables
    private float Speed = 10.0f;
    private float turnspeed = 25.0f;
    private float horizontalInput;
    private float forwardInput; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        // Player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Move vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * Speed * forwardInput);
        // Vehicle Turning
        transform.Rotate(Vector3.up, Time.deltaTime * turnspeed * horizontalInput);
    }
}
                    