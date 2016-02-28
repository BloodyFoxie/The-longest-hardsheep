using UnityEngine;
using System.Collections;

public class ControlPlayer1 : MonoBehaviour {

	public float speed ;
	public Vector2 limit ; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		transform.Translate(0, 0, Input.GetAxis("Horizontal")*speed*Time.deltaTime);

		// Vérifier si la position du player dépasse les limites du terrain et de le replacer si c'est le cas
		if (transform.position.z > limit.y) transform.position = new Vector3( transform.position.x ,transform.position.y, limit.y);

		if (transform.position.z < limit.x) transform.position = new Vector3( transform.position.x, transform.position.y, limit.x);
	
	}
}
