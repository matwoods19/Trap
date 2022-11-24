using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {

    public Waypoints[] wayPoints;
    public float speed = 5f;
    public bool isCircular;
    public bool inReverse = true;

    private Waypoints currentWaypoint;
    private int currentIndex = 0;
    private bool isWaiting = false;
    private float speedStorage = 0;

    void Start()
    {
        if (wayPoints.Length > 0)
        {
            currentWaypoint = wayPoints[0];
        }
    }

    void Update()
    {
        if (currentWaypoint != null && !isWaiting)
        {
            MoveTowardsWaypoint();
        }

    }

    void Pause()
    {
        isWaiting = !isWaiting;
    }

    private void MoveTowardsWaypoint()
    {
        //Get the moving objects current position
        Vector3 currentPosition = this.transform.position;

        //get the target waypoints position
        Vector3 targetPosition = currentWaypoint.transform.position;

        //if the moving object isn't that close to the waypoint
        if (Vector3.Distance(currentPosition, targetPosition) > .1f)
        {
            //get the direction and normalize
            Vector3 directionOfTravel = targetPosition - currentPosition;
            directionOfTravel.Normalize();

            //scale the movement on each axis by the DirectionOfTravel vector
            this.transform.Translate(
                directionOfTravel.x * speed * Time.deltaTime,
                directionOfTravel.y * speed * Time.deltaTime,
                directionOfTravel.z * speed * Time.deltaTime,
                Space.World
                );
        }
        else
        {
            //fi the waypoint has a puase amount then wait a bit
            if (currentWaypoint.waitSeconds > 0)
            {
                Pause();
                Invoke("Pause", currentWaypoint.waitSeconds);
            }

            //if the current waypoint has a speed change then change it to
            if (currentWaypoint.speedOut > 0)
            {
                speedStorage = speed;
                speed = currentWaypoint.speedOut;
            }
            else if (speedStorage != 0)
            {
                speed = speedStorage;
                speedStorage = 0;
            }
            NextWaypoint();
        }
    }

    private void NextWaypoint()
    {
        if (isCircular)
        {
            if (!inReverse)
            {
                currentIndex = (currentIndex + 1 >= wayPoints.Length) ? 0 : currentIndex + 1;
            }
            else
            {
                currentIndex = (currentIndex == 0) ? wayPoints.Length - 1 : currentIndex - 1;
            }
        }
        else
        {
            if ((!inReverse && currentIndex + 1 >= wayPoints.Length) || (inReverse && currentIndex == 0))
            {
                inReverse = !inReverse;
            }
            currentIndex = (!inReverse) ? currentIndex + 1 : currentIndex - 1;
        }
        currentWaypoint = wayPoints[currentIndex];
    }
}
