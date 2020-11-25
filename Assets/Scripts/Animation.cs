using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    //Gets the animator component to activate the animation
    public Animator Ani;

    //Sets bool to false.
    bool Throw = false;

    // Update is called once per frame.
    void Update()
    {
        //Activates the animation on the press of the W key.
        if (Input.GetKeyDown(KeyCode.T))
        {
            Throw = true;
            Ani.SetBool("throw", true);
        }

        //Stops the animation when you let go of the key and the aniamtion ends.
        else if (Input.GetKeyUp(KeyCode.T))
        {
            Throw = false;
            Ani.SetBool("throw", false);
        }
    }
}