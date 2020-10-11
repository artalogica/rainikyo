using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particlePlay : MonoBehaviour
{
    // Start is called before the first frame update
    public ParticleSystem small; 
    void Start()
    {
     // idk why the particles aren't playing so i'll do it manually
    }

    // Update is called once per frame
    void Update()
    {
        small.Emit(1); 
    }
}
