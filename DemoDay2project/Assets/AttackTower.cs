using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AttackTower : MonoBehaviour
{
    public float towerRadius = 5f;
    public float damage = 100f;
    public float towerAttackRate = 4f;
    

    Transform Tower;
    

    
    
    
    // Start is called before the first frame update
    void Start()
    {
        Tower = TowerManager.instance.TurretTower.transform;
      
    }
    private float nextTimetofire = 0f;
    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(Tower.position, transform.position);
        TowerHealth towers = Tower.transform.GetComponent<TowerHealth>();

        while (distance <= towerRadius && Time.time >= nextTimetofire)
        {
            nextTimetofire = Time.time + 2f / towerAttackRate;
            attackingtower();


        }

        

        }



    void attackingtower()
    {

        float distance = Vector3.Distance(Tower.position, transform.position);
        TowerHealth towers = Tower.transform.GetComponent<TowerHealth>();

        if (towers != null)
        {
            towers.TakeDamage(damage);

        }




    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, towerRadius);



    }
}

