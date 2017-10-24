﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seek : MonoBehaviour {

	public Transform target;
	Rigidbody seeker;
	public float thurst;

	// Use this for initialization
	void Start () {
		seeker = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 targetDir = Vector3.Normalize (target.position - transform.position);
		seeker.AddForce (targetDir * thurst);
	}

	}
