﻿using UnityEngine;
using System.Collections;
//Notes have Collider and RigidBody for Collision Detection and its a non-static object
//Script for the Red Note and only the Red Note!!

public class Note : MonoBehaviour {
	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(new Vector3(-5, 0, 0) * Time.deltaTime);
		
		
		if (!GetComponent<Renderer> ().isVisible)
		{
			Destroy(gameObject);
			Debug.Log("Destroyed");
		}
	}

}
