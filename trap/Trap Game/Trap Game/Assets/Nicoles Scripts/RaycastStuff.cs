using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastStuff : MonoBehaviour {

    public GameObject player;
    
    public bool right = false;
    public bool left = false;
    public bool forward = false;
    public bool back = false;
    public float maxDistance;
    public GameObject deathscreen;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(forward == true) //Have a raycast that checks in whatever direction specified and kills the player if the player crosses it
        {
            int layerMask = 1 << 8;

            RaycastHit hit;

            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, maxDistance, layerMask))
            {
                Destroy(player);

                GetComponent<AudioSource>().Play();

                deathscreen.SetActive(true);
            }
            else
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.yellow);
            }
            //Vector3 fwd = transform.TransformDirection(Vector3.forward);

            //Debug.DrawRay(transform.position, fwd, Color.red);

            //if (Physics.Raycast(transform.position, fwd, maxDistance) == player)
            //{
            //    Destroy(player);
            //    deathscreen.SetActive(true);
            //}
        }

        if (back == true)
        {
            //Vector3 fwd = transform.TransformDirection(Vector3.back);

            //Debug.DrawRay(transform.position, fwd, Color.red);

            //if (Physics.Raycast(transform.position, fwd, maxDistance) == player)
            //{
            //    Destroy(player);
            //    deathscreen.SetActive(true);
            //}
            int layerMask = 1 << 8;

            RaycastHit hit;

            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.back), out hit, maxDistance, layerMask))
            {
                Destroy(player);

                GetComponent<AudioSource>().Play();

                deathscreen.SetActive(true);
            }
            else
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.yellow);
            }
        }
        if (right == true)
        {
            //Vector3 fwd = transform.TransformDirection(Vector3.right);

            //Debug.DrawRay(transform.position, fwd, Color.red);

            //if (Physics.Raycast(transform.position, fwd, maxDistance) == player)
            //{
            //    Destroy(player);
            //    deathscreen.SetActive(true);
            //}
            int layerMask = 1 << 8;

            RaycastHit hit;

            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), out hit, maxDistance, layerMask))
            {
                Destroy(player);

                GetComponent<AudioSource>().Play();

                deathscreen.SetActive(true);
            }
            else
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.yellow);
            }
        }
        if (left == true)
        {
            //Vector3 fwd = transform.TransformDirection(Vector3.left);

            //Debug.DrawRay(transform.position, fwd, Color.red);

            //if (Physics.Raycast(transform.position, fwd, maxDistance) == player)
            //{
            //    Destroy(player);
            //    deathscreen.SetActive(true);
            //}

            int layerMask = 1 << 8;

            RaycastHit hit;

            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.left), out hit, maxDistance, layerMask))
            {
                Destroy(player);

                GetComponent<AudioSource>().Play();

                deathscreen.SetActive(true);
            }
            else
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.yellow);
            }
        }

    }

    

   
}
