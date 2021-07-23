using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Attack : MonoBehaviour 
{
    public float attackRadius = 10f;
    public float damage = 5f;
    public float attackRate = 10f;

    Transform target;
    




    // Start is called before the first frame update
    void Start()
    {
        target = PlayerManagerV2.instance.FirstPersonPlayer.transform;
         
       
    }
    private float nextTimetofire = 0f;
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        HerosHelath heros = target.transform.GetComponent<HerosHelath>();
        
        while (distance <= attackRadius && Time.time >= nextTimetofire)
        {
            nextTimetofire = Time.time + 2f / attackRate;
            attacking();


        }
    }
    // Update is called once per frame
    void attacking ()
    {

        float distance = Vector3.Distance(target.position, transform.position);
        HerosHelath heros = target.transform.GetComponent<HerosHelath>();
        
        if (heros != null)
        {
            heros.TakeDamage(damage);


        }
    }



    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, attackRadius);



    }





}












