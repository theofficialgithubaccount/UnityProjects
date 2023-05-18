using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class MoveScriptOncoming : MonoBehaviour
{
    public float speed = 15.0f;
    public float deadZone = -180.0f;
    public GameObject Bus1;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);

        if (transform.position.z < deadZone)
        {
       
             Destroy(Bus1);
        }
    }
}
