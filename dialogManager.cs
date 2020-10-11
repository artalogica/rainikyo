using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class dialogManager : MonoBehaviour
{
    // Start is called before the first frame update

    public TMP_Text said; 
    private int clicks =0; 
    public Animator anim; 
    public Animator starsAlign; 
 
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Dialog(){

        clicks++; 
        StartCoroutine(SomeTimePasses()); 
        switch (clicks){

            case 1: 
            said.SetText("Today is the special day where we will choose"); 
            break; 
            case 2: 
            said.SetText("The one who will take the journey."); 
            break; 
            case 3: 
            said.SetText("The stars will choose your fate..."); 
            break; 
            case 4: 
                // move onto the animation 
                anim.SetTrigger("clicked"); 
                GameObject button = GameObject.Find("Button"); 
                button.SetActive(false); 
                
                starsAlign.SetTrigger("giveStar");   
            break; 

        }
        StartCoroutine(SomeTimePasses()); 


        
         

    }

    IEnumerator SomeTimePasses(){
        yield return new WaitForSeconds(0.5f); 
    }
}
