using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPins : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.z >= 89 || transform.position.z <= -89) {
			Destroy (this);
		}
	}
}
