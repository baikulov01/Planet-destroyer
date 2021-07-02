using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour
{

    public Transform target;
    public float localRotate = 6f;

    void Start()
    {
        
    }

    public void DoLocalRotate()
    {
        transform.Rotate(Vector3.up, localRotate * Time.deltaTime);
    }

    void Update()
    {
        DoLocalRotate();
    }
}
