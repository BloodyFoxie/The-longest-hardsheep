using UnityEngine;
using System.Collections;

public class JaugeManager : MonoBehaviour {

	public Transform jauge ;
	private float percent ; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void ModifyJauge (int value) {

		percent += value;
		Resize ();

	}

	private void Resize () {

		jauge.localScale = new Vector3( 4.8f* (percent/100), jauge.localScale.y, jauge.localScale.z);

		jauge.localPosition = new Vector3 (-2.4f + jauge.localScale.x /2, jauge.localPosition.y, jauge.localPosition.z);

	}
}
