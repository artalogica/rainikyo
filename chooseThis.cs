using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chooseThis : MonoBehaviour
{ 
    private BoxCollider2D baby; 
    // Start is called before the first frame update
    void Start()
    {
        baby = GetComponent<BoxCollider2D>();
        baby.enabled = !baby.enabled;  
    }

    public void AllowClick(){
        baby.enabled = !baby.enabled; 
    }

     void OnMouseDown() {
        //emit some particles and make thing bigger 
    }
    void OnMouseEnter(){
        // change color of the baby 
    }
}
