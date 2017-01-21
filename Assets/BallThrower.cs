using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallThrower : MonoBehaviour {

	public float forceFactor = 1.0f;

	public void force(float magnitude, Vector3 direction){
		gameObject.GetComponent<Rigidbody> ().AddForce (magnitude * forceFactor * direction);
	}
}
