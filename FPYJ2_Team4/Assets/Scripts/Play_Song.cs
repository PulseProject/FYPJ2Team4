using UnityEngine;
using System.Collections;
using UnityEngine.UI;
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
		InvokeRepeating ("SongStart", 1, 0.857f);
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
		yield return new WaitForSeconds(1.714f);
	}
	// Update is called once per frame
	void SongStart () 
	{
		//StartCoroutine(NoteDelay());
		Instantiate(RedNote, new Vector3 (8.0f, -2.0f, 0), Quaternion.identity);
		StartCoroutine(NoteDelay());
		
		
		part += 1;
		//Debug.Log ("Part: " + part);
		
	}




}
