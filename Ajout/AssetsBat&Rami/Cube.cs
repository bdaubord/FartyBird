using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("up"))
						transform.rigidbody.AddForce (new Vector3 (0, 25, 0));
	
	}
}
