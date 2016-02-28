using UnityEngine;
using System.Collections;

public class GenerateTerrain : MonoBehaviour {

	public GameObject[] patterns ; 
	private Transform[] currentPatterns = new Transform [3];
	public GameObject emptyPattern ; 
	private GameObject lastGO ; 
	public Transform level ;

	// Use this for initialization
	void Start () {
	
		lastGO = Instantiate (emptyPattern, new Vector3( 0, 0, 0) , Quaternion.identity) as GameObject;

		lastGO.transform.parent = level; 

		currentPatterns[0] = lastGO.transform;

		lastGO = Instantiate (patterns[Random.Range(0, patterns.Length -1)], new Vector3( 30, 0, 0), Quaternion.identity) as GameObject;

		lastGO.transform.parent = level; 

		currentPatterns[1] = lastGO.transform;

		lastGO = Instantiate (patterns[Random.Range(0, patterns.Length -1)], new Vector3( 60, 0, 0), Quaternion.identity) as GameObject;
		
		lastGO.transform.parent = level; 
		
		currentPatterns[2] = lastGO.transform;

	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (currentPatterns[0].position.x < -30) GenerateNext ();
	

	}

	void GenerateNext () {

		GameObject.Destroy(currentPatterns[0].gameObject);

		currentPatterns[0] = currentPatterns[1];

		currentPatterns[1] = currentPatterns[2];

		lastGO = Instantiate (patterns[Random.Range(0, patterns.Length -1)], new Vector3( 60, 0, 0), Quaternion.identity) as GameObject;

		lastGO.transform.parent = level; 
		
		currentPatterns[2] = lastGO.transform;


	}

}
