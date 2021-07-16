using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRocket : MonoBehaviour
{

    public Rocket Rocket;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition);
            
            Debug.Log(pos);
            
            Instantiate(Rocket, new Vector3(pos.x, pos.y, pos.z), Quaternion.identity);
            
        }
        //Rocket.transform.LookAt(GameObject.FindGameObjectsWithTag("Planet")[0].transform.position);
        //Instantiate(Rocket, new Vector3(pos.x, pos.y, pos.z), Quaternion.identity);
    }
}
