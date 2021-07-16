using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[ExecuteInEditMode]
public class Rocket : MonoBehaviour
{
    public float speed = 5.0f;
    public Transform physicsExplosion;

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.LookAt(GameObject.Find("Centre").transform.position);
        //if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.back), 1.4f))
        //{
        //    Dead();
        //}

        if ((gameObject.transform.position - GameObject.Find("Centre").transform.position).sqrMagnitude > 10000.0)
        {
            Dead();
        }
    }

    void Dead()
    {
        
        Instantiate(physicsExplosion,transform.position,transform.rotation);
        Destroy(gameObject);
    }

    void OnCollisionEnter()
    {
        Dead();
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, transform.TransformDirection(Vector3.forward)*1.4f);
    }

}
