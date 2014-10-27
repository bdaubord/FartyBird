using UnityEngine;
using System.Collections;

public class SpriteHandler : MonoBehaviour {

	public Sprite chicken_down;
	public Sprite chicken_up;
	public Sprite chicken_eggs;
	public Sprite chicken_prout;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("up")) {
			rigidbody2D.AddForce(new Vector2(0,1)*50);
		}

		if (rigidbody2D.velocity.y > 0) {
			GetComponent<SpriteRenderer> ().sprite=chicken_up;
		}

		if (rigidbody2D.velocity.y < 0) {
			GetComponent<SpriteRenderer> ().sprite=chicken_down;
		}

		transform.position = new Vector3 (0, transform.position.y, transform.position.z);
		transform.Rotate(new Vector3 (0,0,0));
	}

	void OnCollisionEnter(Collision col){
		Debug.Log ("coucou");
	}
}
