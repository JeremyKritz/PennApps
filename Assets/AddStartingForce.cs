using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddStartingForce : MonoBehaviour {
    Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(200.0f, 200.0f, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
