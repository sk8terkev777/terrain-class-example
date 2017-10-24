using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destry : MonoBehaviour {
	public GameObject DestroyMe;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (1)) {Destroy (DestroyMe);}
	}
}
