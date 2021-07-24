using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float forceRadius = 3.0f;
    public float force;
    void Update()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, forceRadius);

        for (int i = 0; i < hitColliders.Length; i++)
        {
            if (hitColliders[i].GetComponent<CanBeDestroyed>())
            {
                hitColliders[i].GetComponent<CanBeDestroyed>().Dead();
            }
            if (hitColliders[i].CompareTag("CanBeRigidbody"))
            {
                hitColliders[i].gameObject.AddComponent<Rigidbody>();
                hitColliders[i].attachedRigidbody.mass = 10;
                hitColliders[i].attachedRigidbody.AddExplosionForce(force,transform.position,forceRadius);
            }
        }
        Destroy(gameObject,0.3f);
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, forceRadius);
    }
}
