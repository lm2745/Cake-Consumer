using UnityEngine;
using System.Collections;

public class Mary : MonoBehaviour {

	GameObject other;
	float randy;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//GetComponent<Rigidbody>().AddForce(Vector3.left * 2000 * Time.deltaTime);
	
	}

	void OnTriggerEnter (Collider other){

		if (other.tag == "Player") {
			//Destroy (other.gameObject); 
			Application.LoadLevel ("GameOver");
		}
		//if (other.tag == "Wall") {
		//	randy = Random.Range (90,180);
		//	transform.Rotate(randy,0,0);
		//}
	}

}