using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public GameObject target;
    public int damage=0;
    [Range (0,1)] public float projectileSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void Update()
    {
        Movement();
        if (target==null)
        {
            target = this.gameObject.GetComponentInParent<Tower>().GetCurrenTarget();
        }
    }


    private void Movement()
    {
        if (target!=null)
        {
            
            Vector3 startingPos = this.gameObject.transform.position;
            Vector3 targetPos = target.transform.position;
            transform.LookAt(targetPos);
            this.transform.position = Vector3.Lerp(startingPos, targetPos, projectileSpeed);
        }
    }

    public void SetTarget(GameObject targetx)
    {
        this.target = targetx;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<EnemyMovement>())
        {
           // Destroy(this.gameObject);
        }
    }



}
