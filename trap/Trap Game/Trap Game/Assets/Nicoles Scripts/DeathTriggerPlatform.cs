using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTriggerPlatform : MonoBehaviour
{
    public GameObject player;
    public GameObject deathscreen;
    private void OnTriggerEnter(Collider other) //If the player hits this object they die
    {
        if (other.GetComponent<Collider>().tag == "Player")
        {
            //Debug.Log("You died");
            //Destroy(player);
            deathscreen.SetActive(true);
        }
    }
}
