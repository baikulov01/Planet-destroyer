using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{

    public Transform target;
    public new Transform camera;
    public float speed = 10.0f;
    public float zoom_speed = 1.0f;

    
    void Start()
    {
        
    }

    public void Moove()
    {
        
        Debug.Log(camera.position.z);

        if (Input.GetKey(KeyCode.W))
        {
            camera.RotateAround(target.position, Vector3.right, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            camera.RotateAround(target.position, Vector3.left, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            camera.RotateAround(target.position, Vector3.up, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            camera.RotateAround(target.position, Vector3.down, speed * Time.deltaTime);
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if (camera.position.z < 50.0)
                transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Lerp(transform.position.z, transform.position.z + zoom_speed, 1));
            

        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if (camera.position.z > 15.0 )
                transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Lerp(transform.position.z, transform.position.z - zoom_speed, 1));

        }
    }

    // Update is called once per frame
    void Update()
    {
        camera.LookAt(target);
        Moove();
    }
}


