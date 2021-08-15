using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<Waypoint> levelPath = new List<Waypoint>();

    void Awake()
    {
        SetUpSingleton();
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
