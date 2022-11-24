using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripWireBehavior : MonoBehaviour {

    public GameObject player;

    public bool right = false;
    public bool left = false;
    public bool forward = false;
    public bool back = false;
    public float maxDistance;
    public bool playerRun = false;
    public bool firstlevel = false;

    public float teleport;

    public float MaxTime = 100;
    public float MinTime = 0;

	void Update () {

        // This makes a raycast that goes in whichever direction specified and see's if the player is there
        if (forward == true) 
        {
            int layerMask = 1 << 8;

            RaycastHit hit;

            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, maxDistance, layerMask))
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
                Debug.Log("Did Hit");

                teleport = Random.Range(MinTime, MaxTime);

                if (teleport <= 45)
                {
                    player.transform.position = new Vector3(-6, -2, 13);

                    GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.yellow);
            }

        }

        if (back == true)
        {
            int layerMask = 1 << 8;

            RaycastHit hit;

            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.back), out hit, maxDistance, layerMask))
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.back) * hit.distance, Color.red);
                Debug.Log("Did Hit");

                teleport = Random.Range(MinTime, MaxTime);

                if (teleport <= 45)
                {
                    player.transform.position = new Vector3(-6, -2, 13);

                    GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.yellow);
            }

        }
        if (right == true)
        {
            int layerMask = 1 << 8;

            RaycastHit hit;

            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), out hit, maxDistance, layerMask))
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.right) * hit.distance, Color.red);
                Debug.Log("Did Hit");

                teleport = Random.Range(MinTime, MaxTime);

                if (teleport <= 45)
                {
                    player.transform.position = new Vector3(-6, -2, 13);

                    GetComponent<AudioSource>().Play();
                }

                
            }
            else
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.yellow);
            }
        }
        if (left == true)
        {
            int layerMask = 1 << 8;

            RaycastHit hit;

            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.left), out hit, maxDistance, layerMask))
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.left) * hit.distance, Color.red);
                Debug.Log("Did Hit");

                teleport = Random.Range(MinTime, MaxTime);

                if (teleport <= 45)
                {
                    player.transform.position = new Vector3(-6, -2, 13);

                    GetComponent<AudioSource>().Play();
                }

                if (firstlevel == true)
                {
                    UnityEngine.SceneManagement.SceneManager.LoadScene(1);

                    GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.yellow);
            }
        }
    }
}
