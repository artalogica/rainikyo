using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleScript : MonoBehaviour
{

    public ParticleSystem particleEmitter;
    private bool shooting = true;  
    public float much = 20; 

    

    // Update is called once per frame
    void Update()
    {
     float rotateHorizontal = Input.GetAxis ("Mouse X");
        if(Input.GetButton("Fire1")&& shooting){
            particleEmitter.Emit(1);  
            
            StartCoroutine(WaitIt()); 
    }
    if (Input.GetButton("Fire1")){
        transform.Rotate(0.0f, 0.0f,-rotateHorizontal*much,Space.World); 
    }


            
    }

    IEnumerator WaitIt(){

        shooting = false; 
        yield return new WaitForSeconds(0.2f); 
        shooting = true; 
    }
}
