using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisapearingPlatform : MonoBehaviour {
    //Script for the platform that will disapear when the player walks on it

    public float time = 2;
    public BoxCollider platform;
    public MeshRenderer p1;
    private bool platformGone;
	
	// Update is called once per frame
	void Update ()
    {
        //Debug.Log(time);
	    if(time > 0)
        {
            platform.enabled = true;
            p1.enabled = true;
            Debug.Log("Platforms there");
        }

        //if(platformGone == true)
        //{
        //    time += .5f;
        //    if(time == 2)
        //    {
        //        platform.enabled = true;
        //    }
        //}
	}

    private void OnTriggerStay(Collider other) // if the player hits this platform it dissapears
    {
        if (other.GetComponent<Collider>().tag == "Player")
        {
            time -= Time.deltaTime;
            if (time <= 0)
            {
                platform.enabled = false;

                p1.enabled = false;

                //platformGone = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.GetComponent<Collider>().tag == "Player")
        {
            platform.enabled = true;

            p1.enabled = true;

            time = 2;
        }
    }
}
