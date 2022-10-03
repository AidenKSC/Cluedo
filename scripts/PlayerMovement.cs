using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed = 3f;
    public float Distance = 0f;
    public Transform[] Waypoints;
    public Transform targetWP;
    public int targetWPindex;
    public Transform WaypointsParent; 

    // Start is called before the first frame update
    void Start()
    {

        GetWaypoints();
        targetWP = Waypoints[0];

    }

    // Update is called once per frame
    void Update()
    {
        FollowWaypoints();
    }
    void FollowWaypoints()
    {
        Distance = Vector3.Distance (transform.position, Waypoints[targetWPindex].position);
        if (Distance > 1f)
        {
            Vector3 direction = targetWP.position - transform.position;
            transform.Translate(direction * MoveSpeed * Time.deltaTime);
        }
        else
        {
            targetWPindex++; 
            if (targetWPindex == Waypoints.Length)
            {
                targetWPindex = 0; 
            }
        }
        targetWP = Waypoints[targetWPindex]; 
    }
    void GetWaypoints()
    {
        int numOfWP = WaypointsParent.childCount;
        Waypoints = new Transform[numOfWP]; 
        for (int i = 0; i < Waypoints.Length; i++)
        {
            Waypoints[i] = WaypointsParent.GetChild(i); 
        }

    }
}
