using UnityEngine;
using System.Collections;

public class MoveForward : MonoBehaviour {

	public float speed;

	
	// Update is called once per frame
	void FixedUpdate () {

		transform.Translate(speed*Time.deltaTime, 0, 0);
	
	}
}
