using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScreenTrigger : MonoBehaviour {

    public GameObject player;
    public GameObject winScreen;

    private void OnTriggerEnter(Collider other) //If the player collides with this they win
    {
        if(other.GetComponent<Collider>().tag == "Player")
        {
            winScreen.SetActive(true);
            Debug.Log("You win");
        }
    }
}
