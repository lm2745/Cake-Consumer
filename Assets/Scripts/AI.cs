using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {

	public float speed = 2000;
	public float range = 10;
	int randy;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
		var fwd = transform.TransformDirection (Vector3.forward);
		if (Physics.Raycast (transform.position, fwd, range)) {
			randy = Random.Range (0,90);
			transform.Rotate(0,randy,0);
		}
	}
}
