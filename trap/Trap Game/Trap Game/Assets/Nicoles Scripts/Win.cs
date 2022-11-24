using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour {

    public GameObject WinCanvas;

	public void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Collider>().tag == "Player")
        {
            WinCanvas.SetActive(true);
        }
    }
	
}
