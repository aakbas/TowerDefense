using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public List<Waypoint> path = new List<Waypoint>();
    private int waypointIndex=0;
    private Vector3 nextWaypoint;
    public float moveSpeed;
    public bool isCheckpointReached = false;

    // Start is called before the first frame update
    void Start()
    {
       
    }
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        nextWaypoint= new Vector3(path[waypointIndex].gameObject.transform.position.x,1, path[waypointIndex].gameObject.transform.position.z);        

        if (this.gameObject.transform.position==nextWaypoint)
        {
            waypointIndex++;
        }
        else
        {
            if (path[waypointIndex]!=null)
            {
                this.transform.position = Vector3.Lerp(this.transform.position, nextWaypoint, moveSpeed);
            }
        }

    }






}
