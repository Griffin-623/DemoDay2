using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 25f;
    public float range = 100f;
    public float fireRate = 15f;
    public Camera fpsCam;   
    public ParticleSystem muzzleflash;
    public float impactForce = 30f; 


    private float nextTimetofire = 0f;
    // Update is called once per frame
    void Update(){
        if(Input.GetButton("Fire1") && Time.time >=nextTimetofire)    
        {
            nextTimetofire = Time.time + 4f/fireRate;
            shoot();
           
        }
    
    
    
    }

    void shoot ()
    {
        muzzleflash.Play();
        RaycastHit  hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);  

            Target target = hit.transform.GetComponent<Target>();
        
            if (target != null)
            {
                target.TakeDamage(damage);  
            }

            if( hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }

        }

       
    }





}




