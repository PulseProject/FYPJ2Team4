using UnityEngine;
using System.Collections;

public class Note : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        transform.Translate(new Vector3(0, -5, 0) * Time.deltaTime);
        if (!GetComponent<Renderer>().isVisible)
        {
            Destroy(gameObject); 
        }
	}
}
