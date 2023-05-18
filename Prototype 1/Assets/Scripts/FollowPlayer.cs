using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);
    public bool keyPress = false;
    public int switcher = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown("space"))
        {
            //If space pressed, toggle a value, switcher, between 0 and 1.
            switcher = 1 - switcher;
        }

        if (switcher == 1)
        {
            //Change to driver perspective
            offset = new Vector3(0, 3.7f, 2.1f);
        }
        else
        {
            //Change to third person perspective
            offset = new Vector3(0, 12, -14.5f);
        }

        // Offset the camera's position from the player
        transform.position = player.transform.position + offset;
    }
}
