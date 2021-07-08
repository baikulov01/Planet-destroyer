using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour
{

    public Transform target;
    public float rotate = 6.0f;

    public void DoRotate()
    {
        transform.Rotate(Vector3.up, rotate * Time.deltaTime);
    }

    void Update()
    {
        DoRotate();
    }
}
