using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderSpawner : MonoBehaviour
{

    public GameObject bolder;

    public Vector3 BolderPosition = new Vector3(8.25f, 1.46f, 37.18f);

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Collider>().tag == "Player")
        {
            Instantiate(bolder,BolderPosition ,Quaternion.identity);
        }
    }
}
