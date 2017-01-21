using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vectorDrawer : MonoBehaviour {


	public GameObject vector;
	public GameObject arrowEnd;
	public GameObject projectile;
	public Camera cam1;
	public Camera cam2;

	private BallThrower thrower;

	private float angle;
	private float arrowMag;
		
	void Awake ()
	{
		thrower = projectile.GetComponent<BallThrower> ();

		cam1.enabled = true;
		cam2.enabled = false;
	}

	void Update () 
	{
		if (Input.GetMouseButton (0)) {
			Vector3 mousePos = Input.mousePosition;
			Ray camRay = Camera.main.ScreenPointToRay(mousePos);
			RaycastHit hit;
			if (Physics.Raycast (camRay, out hit)) {
				Debug.Log (hit.point);

				if (hit.point.x < vector.transform.position.x) {
					vector.transform.position = vector.transform.up * (1.5f - hit.point.magnitude / 2f);
					vector.transform.localScale = new Vector3 (1f, hit.point.magnitude, 1f);
					arrowEnd.transform.position = vector.transform.up * (1.5f - hit.point.magnitude);

					angle = Mathf.Atan ((hit.point.y) / (hit.point.x)) * Mathf.Rad2Deg;
					arrowMag = hit.point.magnitude;
					
					vector.transform.eulerAngles = new Vector3 (0f, 0f, angle + 90f);
					arrowEnd.transform.eulerAngles = new Vector3 (0f, 0f, angle + 90f);
				}
			}
		}
	}

	public void ApplyForce(){
		cam1.enabled = false;
		cam2.enabled = true;

		thrower.force (arrowMag, arrowEnd.transform.position - vector.transform.position);
		print (-vector.transform.forward);
	}

}
