using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float Radius;
    public float Force;
    void Update()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, Radius);
        for (int i = 0; i < hitColliders.Length; i++)
        {
            if (hitColliders[i].GetComponent<CanBeDestroyed>())
            {
                hitColliders[i].GetComponent<CanBeDestroyed>().Dead();
            }

        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position,Radius);
    }
}
