using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMouse : MonoBehaviour
{
    //sensitivity should be a fraction
    public float sensitivity; 
  
    void FixedUpdate() {
        float rotateHorizontal = Input.GetAxis ("Mouse X");
         float rotateVertical = Input.GetAxis ("Mouse Y");
        transform.Rotate(-transform.up * rotateHorizontal * sensitivity); 
        transform.Rotate(-transform.right * rotateVertical * sensitivity); 
        // transform.Translate(rotateVertical*sensitivity,rotateHorizontal*sensitivity,Time.deltaTime); 
        // Debug.Log("x: "+ rotateHorizontal); 
        // Debug.Log("y: " + rotateVertical); 
    }
  
}
