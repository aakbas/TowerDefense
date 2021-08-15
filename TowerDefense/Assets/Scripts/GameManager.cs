using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<Waypoint> levelPath = new List<Waypoint>();
    public GameObject towerPrefab;

    void Awake()
    {
        SetUpSingleton();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                if (hit.collider.gameObject.GetComponent<Waypoint>())
                {
                    hit.collider.gameObject.GetComponent<Waypoint>().SpawnTower(towerPrefab);
                }
            }



        }
    }

    public List<Waypoint> GetLevelWaypoint()
    {
        return levelPath;
    }
    private void SetUpSingleton()
    {
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
