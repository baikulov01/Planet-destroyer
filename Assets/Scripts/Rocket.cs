using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[ExecuteInEditMode]
public class Rocket : MonoBehaviour
{
    public float speed = 2.0f;
    public Transform physicsExplosion;

    public void Start()
    {
        
    }
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), 1.4f)) 
        {
            Dead();
        }
    }

    void Dead()
    {
        
        Instantiate(physicsExplosion,transform.position,transform.rotation);
        Destroy(gameObject);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, transform.TransformDirection(Vector3.forward)*1.4f);
    }

}
