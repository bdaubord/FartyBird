using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Player : MonoBehaviour {

	GameObject sphere;
	int _pv = 3;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		// Up
		if (Input.GetKeyDown(KeyCode.Z))
		{
			transform.rigidbody.AddForce (Vector3.up * 10000 * Time.deltaTime);
			sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
			sphere.transform.position = new Vector3 (this.transform.position.x, this.transform.position.y -1f, this.transform.position.z);
			sphere.AddComponent("Rigidbody");
		}

		// Down
		if (!Input.GetKeyDown (KeyCode.Z)) 
		{
			transform.rigidbody.AddForce (Vector3.down * 500 * Time.deltaTime);

		}

		// press 'D' to shoot
		if (Input.GetKeyDown (KeyCode.D)) 
		{
			sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);

			sphere.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
			sphere.AddComponent("ShootScript");
			sphere.AddComponent("Rigidbody");
			sphere.rigidbody.useGravity = false;
		}
	}

	// colision
	void OnCollisionEnter(Collision collision) 
	{
		_pv--;
	}

	// GameOver
	void OnGUI()
	{
		if (_pv == 0) 
		{

		}
	}
}