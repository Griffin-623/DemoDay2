using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyController : MonoBehaviour
{ 
    public float lookRadius = 20f;
    
    Transform target;
    NavMeshAgent agent;


    
    // Start is called before the first frame update
    void Start()
    {
        target = PlayerManagerV2.instance.FirstPersonPlayer.transform;
        agent = GetComponent<NavMeshAgent>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float distanceOne = Vector3.Distance(target.position, transform.position);

        if (distanceOne <= lookRadius)
        {
            agent.SetDestination(target.position);

          
        }
    }



    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);



    }


}



