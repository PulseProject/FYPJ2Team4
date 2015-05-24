using UnityEngine;
using System.Collections;

public class Play_Song : MonoBehaviour 
{
	public GameObject RedNote;
	public GameObject Blue;
	public GameObject Yellow;
	public GameObject Green;


	public int part = 0;
	// Use this for initialization
	void Start () 
	{

		InvokeRepeating ("SongStart", 2, 1);
		//if (part <= 1) {
		//SongStart ();
		
		//	return;
		//}
	}
	void Update()
	{

	}
	IEnumerator NoteDelay()
	{
		//a = 0;
		yield return new WaitForSeconds(2.0f);
	}
	// Update is called once per frame
	void SongStart () 
	{
		StartCoroutine(NoteDelay());
		Instantiate(RedNote, new Vector3 (-1.5f, 5.0f, 0), Quaternion.identity);
		StartCoroutine(NoteDelay());
		
		
		part += 1;
		//Debug.Log ("Part: " + part);
		
	}




}
