using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanBeDestroyed : MonoBehaviour
{
    public Transform destroyed;

    public void Dead()
    {
        Instantiate(destroyed, transform.position, Quaternion.Euler(0, gameObject.transform.eulerAngles.y, 0));
        Destroy(gameObject);
    }

}
