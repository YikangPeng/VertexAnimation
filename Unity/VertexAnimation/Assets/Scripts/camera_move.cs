using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_move : MonoBehaviour
{

    public Camera camera;
    public float speed = 0.02f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 forward = Vector3.ProjectOnPlane(camera.transform.forward, Vector3.up).normalized;
        Vector3 right = Vector3.ProjectOnPlane(camera.transform.right, Vector3.up).normalized;

        Vector3 move = (v * forward + h * right).normalized * speed;

        transform.position += move;

        
    }
}
