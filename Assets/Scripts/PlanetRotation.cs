using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour
{

    public Transform target;
    public float rotate = 6.0f;

    void Update()
    {
        transform.Rotate(0, 0, rotate * Time.deltaTime);
    }
}
