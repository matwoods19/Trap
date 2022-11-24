using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWalls : MonoBehaviour {

    public MeshRenderer WallRenderer;
    public BoxCollider WallCollider;
    public MeshCollider WallMesh;

    public float MaxTime;
    public float MinTime;

    public float Disappear;
    public float Reappear;

    private void Start()
    {
        Disappear = Random.Range(MinTime, MaxTime);
    }

    void FixedUpdate ()
    {
        if(Disappear > 0)
        {
            Disappear -= Time.deltaTime;
        }

        if(Disappear < 0)
        {
            Disappear = 0;

            WallRenderer.enabled = false;
            WallCollider.enabled = false;
            WallMesh.enabled = false;

            Reappear = Random.Range(MinTime, MaxTime);
        }

        if(Disappear == 0)
        {
            Reappear -= Time.deltaTime;

        }

        if(Reappear < 0)
        {
            WallRenderer.enabled = true;
            WallCollider.enabled = true;
            WallMesh.enabled = true;

            Disappear = Random.Range(MinTime, MaxTime);

            Reappear = 0;
        }
	}
}
