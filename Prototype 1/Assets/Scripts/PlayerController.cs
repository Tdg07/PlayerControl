using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 5.0f;
    public float turnspeed;
    public float horizontalInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        horizontalInput = Input.GetAxis("Horizontal");

        // Move vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * 20);
        transform.Translate(Vector3.right * Time.deltaTime * turnspeed * horizontalInput);
    }
}
