using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] private bool isPlaceable = true;   
    private Vector3 spawnPoint;

    void Start()
    {
        spawnPoint = new Vector3(this.gameObject.transform.position.x, 1, this.gameObject.transform.position.z);
    }

   

    public void SpawnTower(GameObject towerPrefab)
    {
        if (isPlaceable)
        {
            var spawnedTower = Instantiate(towerPrefab, spawnPoint, Quaternion.identity);
            spawnedTower.transform.parent = this.gameObject.transform;
            isPlaceable = false;

        }
    }



}
