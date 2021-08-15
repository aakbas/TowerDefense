using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLocator : MonoBehaviour
{
    [SerializeField] private GameObject weapon;
    public GameObject target=null;
    private bool isAimed;
    [SerializeField] private bool isRotateable = true;

        

    // Update is called once per frame
    void Update()
    {
        if (isRotateable)
        {
            AimWeapon();
        }
    }

    private void AimWeapon()
    {

        if (target!=null)
        {
            weapon.gameObject.transform.LookAt(target.transform.position);
        }

    }


    void OnTriggerStay(Collider other)
    {
        if (!isAimed)
        {
            if (other.gameObject.GetComponent<EnemyMovement>())
            {
                
                target = other.gameObject;
                isAimed = true;

            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<EnemyMovement>())
        {
            target = null;
            isAimed = false;
        }
    }

    public GameObject GetTarget()
    {
        return target;
    }



}
