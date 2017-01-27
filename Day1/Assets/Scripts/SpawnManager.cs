using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

    public GameObject dext;                 //global variable that will store the object cloneDext
    public float time = 5f;                 
    public Transform[] spawnPoints;         //just one spawnpoint for now
    public int count = 0;                   //counter
    public int max = 5;                     //number of dexters that you want
    public float waitTime = 2f;             //will wait to spawn (delay)

    void Start()
    {
        
        InvokeRepeating("Spawn", 0, time);
    }

    void Spawn()
    {
        waitTime -= 1;
        print(this.GetComponentInParent<Magic>().shot);
       if (count < max && this.GetComponentInParent<Magic>().shot == true && waitTime <= 0) 
        {
            int spawnPointIndex = Random.Range(0, spawnPoints.Length);
            //spawn a new dexter in random position and rotation
            Instantiate(dext, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            count++;
            waitTime = 2f;
        }
    }
}