using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{

    public Transform target;
    public float speed = 10.0f;  

    public void Moove()
    {

        //var distance = (gameObject.transform.position - target.position).sqrMagnitude;

        if (Input.GetKey(KeyCode.W))
        {
            if (gameObject.transform.localEulerAngles.x < 89.9f || gameObject.transform.localEulerAngles.x > 270.0f)
            {
                
                gameObject.transform.RotateAround(target.position, Vector3.left, speed * Time.deltaTime);
            }
         
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (gameObject.transform.localEulerAngles.x <= 90.1f && gameObject.transform.localEulerAngles.x >= 0.0f || gameObject.transform.localEulerAngles.x <= 360.0f && gameObject.transform.localEulerAngles.x >= 270.1f)
            {
                
                gameObject.transform.RotateAround(target.position, Vector3.right, speed * Time.deltaTime);
            }
             
        }
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.RotateAround(target.position, Vector3.up, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.RotateAround(target.position, Vector3.down, speed * Time.deltaTime);
        }
      
    }


    void Update()
    {
        //Debug.Log(gameObject.transform.localEulerAngles);
        //gameObject.transform.LookAt(target);
        Moove();
    }
}


