using UnityEngine;
using System.Collections;


//Script for the Red Note and only the Red Note!!

public class Note : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {

	}
	
	// Update is called once per frame
	void Update () 
    {
		transform.Translate(new Vector3(0, -5, 0) * Time.deltaTime);
		if (!gameObject.GetComponent<Renderer> ().isVisible)
		{
			Destroy(gameObject);
			Debug.Log("Destroyed");
		}
	}
}
