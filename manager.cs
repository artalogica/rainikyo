using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour
{

    private GameObject star; 
    private unlockBaby unlock; 
    private int succeed; 
    private GameObject particle; 
    private GameObject baby; 

    private bool allUnlocked = false; 
    public float sensitivity; 
    public Camera cam;  

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {

        
        if(succeed == 3){
            allUnlocked = true; 
        }
        for(int i = 0; i<3; i++){
         if(i==0){
            star = GameObject.Find("star"); 
            baby = GameObject.Find("/star/Baby"); 
         }else{
           star = GameObject.Find("star ("+i+")"); 
           baby = GameObject.Find("/star (" + i+ ")/Baby"); 
         }
        
         unlock = star.GetComponent<unlockBaby>(); 

        if(unlock.abletoChoose){
            succeed++; 
            Debug.Log(succeed); 
            unlock.abletoChoose = false; 
        }

        if(allUnlocked){
        //    baby.GetComponent<chooseThis>().AllowClick();
        allUnlocked = false; 
  
        }
     }  

    }

    private void FixedUpdate() {
          float rotateHorizontal = Input.GetAxis ("Mouse X");
         float rotateVertical = Input.GetAxis ("Mouse Y");
        cam.transform.Rotate(-transform.up * rotateHorizontal * sensitivity); 
        cam.transform.Rotate(-transform.right * rotateVertical * sensitivity); 
    }
}
