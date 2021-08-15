using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{

    private TargetLocator myLocator;
   [SerializeField] private GameObject target;
    public float cooldown = 1f;
    private bool onCooldown=false;
    [SerializeField] private GameObject projectilePrefab;

    void Awake()
    {
        myLocator = this.gameObject.GetComponent<TargetLocator>();
    }
    // Start is called before the first frame update
    

    private IEnumerator Shoot()
    {

        if (target != null && !onCooldown)
        {
            Debug.Log("test");
            onCooldown = true;
            var spawnedProjectile = Instantiate(projectilePrefab, this.transform.position, Quaternion.identity);
            spawnedProjectile.transform.parent = this.gameObject.transform;
            yield return new WaitForSeconds(cooldown);
            onCooldown = false;
        }
    }


    void Update()
    {
        target = myLocator.GetTarget();
        StartCoroutine(Shoot());
    }

    public GameObject GetCurrenTarget()
    {
        return target;
    }

}
