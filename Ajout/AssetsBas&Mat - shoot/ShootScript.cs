using UnityEngine;
using System.Collections;

public class ShootScript : MonoBehaviour {
	
	GameObject cube;

	Ennemy e;

	// Use this for initialization
	void Start () {
		cube = GameObject.Find ("Cube");
		this.transform.position = new Vector3 (cube.transform.position.x, cube.transform.position.y, cube.transform.position.z + 1f);
		e = GameObject.Find ("GameManager").GetComponent<Ennemy> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.z <= 5) {
						this.transform.position += new Vector3 (0f, 0f, 10f) * Time.deltaTime;
				}
	}

	// colision
	void OnCollisionEnter(Collision collision) 
	{
		Destroy (gameObject);
		Destroy (collision.gameObject);
		e.addEnnemy ();
	}
}