using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NEWscript : MonoBehaviour
{
    public Transform anAwesomeTransform;    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     // Question: what is Time.deltaTime?
        // Question: how can we increase the rotationSpeed?
        // Question: how can we decrease the rotationSpeed?
       
       // the line bellow moves anAwesomeTransform by the postion Z
        if(Input.GetKey(KeyCode.W))
        anAwesomeTransform.Translate(0,0, Time.deltaTime*8, Space.World);
        if(Input.GetKey(KeyCode.S))
        anAwesomeTransform.Translate(0,0,Time.deltaTime*-8, Space.World);
        if(Input.GetKey(KeyCode.A))
        anAwesomeTransform.Translate(Time.deltaTime*-8,0,0, Space.World);
         if(Input.GetKey(KeyCode.D))
        anAwesomeTransform.Translate(Time.deltaTime*8,0,0, Space.World);
       
       
        
        
         
        // anAwesomeTransform.Translate(Vector3.up * Time.deltaTime, Space.World);
   
    }
}
