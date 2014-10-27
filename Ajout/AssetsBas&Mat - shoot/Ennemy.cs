using UnityEngine;
using System.Collections;

public class Ennemy : MonoBehaviour {

	GameObject sphere;

	// Use this for initialization
	void Start () {
		sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
		sphere.transform.position = new Vector3 (-2.7f, 2f, 0f);
		sphere.AddComponent ("Rigidbody");
		sphere.rigidbody.useGravity = false;
	}
	
	// Update is called once per frame
	void Update () {
		sphere.transform.position += new Vector3 (0f, 0f, -8f) * Time.deltaTime;

		if (sphere.transform.position.z <= -15f)
		{
			Destroy(sphere);
			addEnnemy();
		}
	}

	public void addEnnemy()
	{
		sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
		sphere.transform.position = new Vector3 (-2.7f, 2f, 0f);
	}
}
