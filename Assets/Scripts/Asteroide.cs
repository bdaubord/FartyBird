using UnityEngine;
using System.Collections;

public class Asteroide : MonoBehaviour {
	
	public float coefdir;
	public float posy;
	public float choice;
	
	public float speed=0.1F;
	// Use this for initialization
	void Start () {
		coefdir = 0;
		posy = 0;
		choice = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x <= -15 || transform.position.x>= 15) {
			//Re pop
			choice = Random.Range (0, 2);
			Debug.Log (choice);
			posy = Random.Range (-5, 5);
			Debug.Log (posy);
			if (choice == 0) {
				transform.position = new Vector3 (15, posy, 0);
			}
			else{
				transform.position = new Vector3 (-15, posy, 0);
			}
			//Changement de la taille
			int a = Random.Range (1, 3);
			int b = Random.Range (0, 100);
			float bf = (float)a + (float)(b * 0.01F);
			transform.localScale = new Vector3 (bf, bf, bf);
			if(choice == 0){
				if ((posy <= 5) && (posy >= 4))
					b = Random.Range (-40, -25);
				if ((posy < 4) && (posy >= 3))
					b = Random.Range (-30, -15);
				if ((posy < 3) && (posy >= 2))
					b = Random.Range (-20, 5);
				if ((posy < 2) && (posy >= 1))
					b = Random.Range (-30, 15);
				if ((posy < 1) && (posy >= -1))
					b = Random.Range (-30, 30);
				if ((posy < -1) && (posy >= -2))
					b = Random.Range (-15, 30);
				if ((posy < -2) && (posy >= -3))
					b = Random.Range (-5, 20);
				if ((posy < -3) && (posy >= -4))
					b = Random.Range (15, 30);
				if ((posy < -4) && (posy >= -5))
					b = Random.Range (25, 40);
				coefdir = (float)b * 0.01F;
			}
			else{
				if ((posy <= 5) && (posy >= 4))
					b = Random.Range (40, 25);
				if ((posy < 4) && (posy >= 3))
					b = Random.Range (30, 15);
				if ((posy < 3) && (posy >= 2))
					b = Random.Range (20, -5);
				if ((posy < 2) && (posy >= 1))
					b = Random.Range (30, -15);
				if ((posy < 1) && (posy >= -1))
					b = Random.Range (-30, 30);
				if ((posy < -1) && (posy >= -2))
					b = Random.Range (15, -30);
				if ((posy < -2) && (posy >= -3))
					b = Random.Range (5, -20);
				if ((posy < -3) && (posy >= -4))
					b = Random.Range (-15, -30);
				if ((posy < -4) && (posy >= -5))
					b = Random.Range (-25,- 40);
				coefdir = (float)b * 0.01F;
			}
		}
		if (choice == 0) {
			transform.position -= new Vector3 (1 * this.speed, 0, 0);
			transform.position += new Vector3 (0, coefdir * speed, 0);
		} else {
			transform.position -= new Vector3 (-1 * this.speed, 0, 0);
			transform.position += new Vector3 (0, -coefdir * speed, 0);
		}
		
	}
}