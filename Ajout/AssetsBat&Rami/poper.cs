using UnityEngine;
using System.Collections;

public class poper : MonoBehaviour {

	public Transform asteroide;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if((int)Time.timeSinceLevelLoad % (3*Time.deltaTime) == 0)
			Instantiate(this.asteroide, new Vector3(15,(Random.Range(0,10)-5),0),Quaternion.identity);
	}
}
