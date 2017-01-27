using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics : MonoBehaviour {

    public float speed;
    Rigidbody rb;
	// Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speed = 5;
    }

	void FixedUpdate () {
        float leftRight = Input.GetAxis("Horizontal");
        float forwardBack = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(leftRight, 0, forwardBack);
        rb.AddForce(move * speed);
	}
	
}
