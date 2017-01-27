using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic : MonoBehaviour {

    public Transform poof;
    public bool shot = false;
    // Use this for initialization
    void Start()
    {
        var po = poof.GetComponent<ParticleSystem>();           //accessing the Particle System component
        ParticleSystem.EmissionModule shoot = po.emission;      //making shoot a variable that stores the emission's component
        shoot.enabled = false;                                  //initializing the emission to false
        shot = false;
    }

    // Update is called once per frame
    void FixedUpdate() //used for physics
    {
        if (Input.GetKey("e"))
        {
            //poof.GetComponent<ParticleSystem>().enableEmission = false;
            var po = poof.GetComponent<ParticleSystem>();       //accessing the Particle System component, to update
            ParticleSystem.EmissionModule shoot = po.emission;  //update
            shoot.enabled = true;                               //update to true if the key "e" is pressed and held
            shot = true;                                        //Used for another class to see if "e" was triggered
        }
        else
        {
            
            var po = poof.GetComponent<ParticleSystem>();       
            ParticleSystem.EmissionModule shoot = po.emission;
            shoot.enabled = false;
            shot = false;
        }
    }
}