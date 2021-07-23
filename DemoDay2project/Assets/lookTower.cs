using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class lookTower : MonoBehaviour
{

    public float TowerRadius = 120f;

    Transform Tower;
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        Tower = TowerManager.instance.TurretTower.transform;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
        float distance = Vector3.Distance(Tower.position, transform.position);

        if (distance <= TowerRadius)
        {
            agent.SetDestination(Tower.position);


        }
    
    
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, TowerRadius);



    }



}
