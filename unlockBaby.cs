using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlockBaby : MonoBehaviour
{
    public Animator anim;
    public GameObject baby; 
    private GameObject star; 
    private int hits; 
    //the baby color (make it not transparent)
    private SpriteRenderer see; 
    // Update is called once per frame
    public bool abletoChoose; 

    void Start() {
        anim = GetComponent<Animator>();
        see = baby.GetComponent<SpriteRenderer>();  
        baby.SetActive(false);
        star = GameObject.Find("stars");  
    }
    void Update()
    {

    }

    void OnParticleCollision(GameObject other) {
        
            star.GetComponent<SpriteRenderer>().color = new Color(255,247,211); 

        switch (hits){

            case 5: 
                anim.SetTrigger("startRotate"); 
                baby.SetActive(true); 
                
                break; 

            case 10: 
                anim.SetTrigger("showBaby");

                
                break; 
            case 12:
                anim.SetTrigger("grow"); 
                abletoChoose = true; 
                break ; 

        }
        
        hits++; 
    }
}
