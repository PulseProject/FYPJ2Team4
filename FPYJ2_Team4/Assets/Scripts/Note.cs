using UnityEngine;
using System.Collections;


//Script for the Red Note and only the Red Note!!

public class Note : MonoBehaviour {
	
	// Use this for initialization
	private GameObject RED;
	void Start () 
	{
		RED = GameObject.Find ("Note");
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(new Vector3(0, -5, 0) * Time.deltaTime);
		
		if (!GetComponent<Renderer> ().isVisible)
		{
			Destroy(gameObject);
			Debug.Log("Destroyed");
		}
	}
}
