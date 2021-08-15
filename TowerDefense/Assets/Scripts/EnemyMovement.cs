using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    private List<Waypoint> path=new List<Waypoint>();
   
    

    [SerializeField] [Range (0f,0.5f)]  public float moveSpeed=1f;
    public float waypointOffset = 0.05f;

    private GameManager myGameManager;


    

    // Start is called before the first frame update
    void Start()
    {
        myGameManager = FindObjectOfType<GameManager>();
        path = myGameManager.GetLevelWaypoint();
        StartCoroutine(Movement());
    }





    void Update()
    {
        
        
    }

    private IEnumerator Movement()
    {
        foreach (Waypoint waypoint in path)
        {
            Vector3 startPosition = this.transform.position;
            Vector3 waypointPosition = waypoint.transform.position;
            Vector3 nextPosition = waypointPosition +new Vector3(0, 1, 0);
            float travelPercent = 0f;
            transform.LookAt(nextPosition);
            
            while (travelPercent<1)
            {
                travelPercent += Time.deltaTime*moveSpeed;
                this.transform.position = Vector3.Lerp(startPosition, nextPosition, travelPercent);
                yield return new WaitForEndOfFrame();
            }
            
        }
    }

   
   



}
