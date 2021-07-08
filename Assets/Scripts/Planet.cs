using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    private HashSet<Rigidbody> affectedBodies = new HashSet<Rigidbody>();
    private Rigidbody componentRigidbody;

    void Start()
    {
        componentRigidbody = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody != null)
        {
            affectedBodies.Add(other.attachedRigidbody);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.attachedRigidbody != null)
        {
            affectedBodies.Remove(other.attachedRigidbody);
        }
    }

    void Update()
    {
        foreach (Rigidbody item in affectedBodies)
        {
            Vector3 directionToPlanet = (transform.position - item.position).normalized;

            float distance = (transform.position - item.position).magnitude;
            float strength = 9.8f*item.mass * componentRigidbody.mass/distance;

            item.AddForce(directionToPlanet * strength);
        }
    }
}
