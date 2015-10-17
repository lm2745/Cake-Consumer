using UnityEngine;
using System.Collections;
//using Unity.UI; 

public class Player : MonoBehaviour {

    public float speed = 20;
	public AudioSource collisionSound;
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
        if (Input.GetKey (KeyCode.W))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.forward * speed * Time.deltaTime);
        }
		if (Input.GetKey (KeyCode.S))
		{
			GetComponent<Rigidbody>().AddForce(Vector3.forward * -speed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.D))
		{
			GetComponent<Rigidbody>().AddForce(Vector3.right * speed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.A))
		{
			GetComponent<Rigidbody>().AddForce(Vector3.right * -speed * Time.deltaTime);
		}

	}

	void OnCollisionEnter () {
		collisionSound.Play();
	}

}
