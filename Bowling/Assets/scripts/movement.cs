using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

	private Rigidbody rb;
	private bool pressKey = false;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		Random.Range (-10f,10f);

		if (Input.GetKeyDown (KeyCode.Space) && pressKey == false) {
			rb.AddRelativeForce (Vector3.right * Random.Range (-1000f,1000f) + Vector3.back * 20000);
			pressKey = true;
		}

		if (Input.GetKeyDown (KeyCode.R) && pressKey == true && transform.position.z < -14f) {
			pressKey = false;
			transform.position = new Vector3 (-0.1f, 0.74f, 15.04f);
			transform.eulerAngles = new Vector3 (0f,0f,0f);
			rb.velocity = new Vector3(0,0,0);
			rb.angularVelocity = new Vector3 (0,0,0);
		}
	}
}
