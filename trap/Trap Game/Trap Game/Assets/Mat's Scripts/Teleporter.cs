using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour {

    public float teleport;

    public float MaxTime = 100;
    public float MinTime = 0;

    public GameObject player;

    public void Teleport()
    {
            teleport = Random.Range(MinTime, MaxTime);

        if (teleport <= 45)
        {
            player.transform.position = new Vector3(-6, -2, 13);
        }
    }
}
