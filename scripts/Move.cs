using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

public Transform[] waypoints;

[SerializeField]
private float moveSpeed = 1f;

[HideInInspector]
public int waypointIndex =0;

public bool moveAllowed = false;


  private  void Start()
    {
        waypointIndex = 0;
        transform.position = waypoints[waypointIndex].transform.position;
        move();
    }

    // Update is called once per frame
  private  void Update()
    {
        
          move();
    }

    private void move(){
  
        transform.position = Vector2.MoveTowards(transform.position, waypoints[waypointIndex].transform.position, moveSpeed * Time.deltaTime);

        if (transform.position == waypoints[waypointIndex].transform.position){
          waypointIndex += 1;
        }
        if (waypointIndex == waypoints.Length)
        {
            waypointIndex = 0; 
        }
      }

    

}
