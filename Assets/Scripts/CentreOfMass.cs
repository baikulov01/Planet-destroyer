using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CentreOfMass : MonoBehaviour
{
    public Transform CentreOfMassTransform;

    private void Awake()
    {
        GetComponent<Rigidbody>().centerOfMass = CentreOfMassTransform.localPosition;
    }

}
