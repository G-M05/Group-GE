using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class verticalPlatform : MonoBehaviour
{ 
    private PlatformEffector2D effector;
    public float waitTime;

    // Start is called before the first frame update
    void Start()
    {
    effector = GetComponent<PlatformEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.S)) // checks to see if the key has been released
        {
        waitTime = 0.5f;
        }

        if (Input.GetKey(KeyCode.S))//checks to see if s has been pressed
        {
            if (waitTime <= 0) // if s hasnt been pressed the platform only check for collisions from Above
            {
            effector.rotationalOffset = 180f;// makes it rotate to check for collisions from Above
            waitTime = 0.5f;//resets wait time to .5 seconds the key needs to be held down
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
       
    if (Input.GetKey(KeyCode.Space)) //if space key is pressed checks for collision from below so you can jump through it
        {
        effector.rotationalOffset = 0;
        }
    }
}
