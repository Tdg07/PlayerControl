using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject player; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Camera Offset
        transform.position = player.transform.position + new Vector3(0, 5, -7);
    }
}
