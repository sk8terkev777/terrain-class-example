using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thrust : MonoBehaviour {

	Rigidbody rb;
	public float thrustAmt; 
	public AudioSource testSound;
	public AudioClip Theme;
	public GameObject Pin1;
	public GameObject Mii;
	public Vector3 startingPostion;
	public GameObject DestroyMe;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.UpArrow)) {
			rb.AddForce (Vector3.forward * thrustAmt);
			testSound.PlayOneShot (Theme, 0.7f);
		}

		if(Input.GetKey (KeyCode.DownArrow)){
				rb.AddForce (Vector3.back * thrustAmt);

		}
	

		if (Input.GetKey (KeyCode.LeftArrow)) {
			rb.AddForce (Vector3.left * thrustAmt);
		}
	
	   
		if (Input.GetKey (KeyCode.RightArrow)) {
			rb.AddForce (Vector3.right * thrustAmt);
		}
	
		if (Mii.transform.position == Pin1.transform.position){
			Mii.transform.position = startingPostion;
		}
	
		if (Mii.transform.position.z > 280) {
			Mii.transform.position = startingPostion;
		}
	
	
	
		Ray beam = Camera.main.ScreenPointToRay (Input.mousePosition);

		Debug.DrawRay (beam.origin, beam.direction * 1000f);
	  
		RaycastHit beamHit = new RaycastHit ();

		if (Physics.Raycast (beam, out beamHit, 1000f)) {
			Debug.Log ("You hit something");
			if (Input.GetMouseButtonDown (0)) {
				Destroy (beamHit.collider.gameObject);
			}


		}

		if (Input.GetMouseButtonDown (1)) {
			beamHit.rigidbody.AddForce (Vector3.forward * 1000f);
		}

	
	

	
	
	
	
	
	}
}
