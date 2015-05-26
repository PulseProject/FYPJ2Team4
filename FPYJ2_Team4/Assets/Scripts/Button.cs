using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//With Collider but without RigidBody since its static
public class Button : MonoBehaviour {


	// Use this for initialization
	public bool touching = false;
	public int combo;
	public Text ComboCounter;
	public int score;
	public Text ScoreCounter;
	public float myDistance;
	public Collision2D col;

	public GameObject note;

	void Start () {
		combo = 0;
		ComboCounter.text = ""+combo;
		score = 0;
		ScoreCounter.text = "SCORE: "+score;
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log ("isTouching: " + isTouching());
	}


	void OnTriggerEnter2D(Collider2D coll)
	{
		if (Input.GetMouseButtonDown (0)) {
			if (coll.gameObject.tag == "Note") {
				++combo;
				ComboCounter.text = "" + combo;
				score += Random.Range (8, 12);
				ScoreCounter.text = "SCORE: " + score;
				Destroy (coll.gameObject);
			} 
		}
	}

	void OnTriggerStay2D(Collider2D coll)
	{
		if (Input.GetMouseButtonDown (0)) {
			if (coll.gameObject.tag == "Note") {
				++combo;
				ComboCounter.text = "" + combo;
				score += Random.Range (8, 12);
				ScoreCounter.text = "SCORE: " + score;
				Destroy (coll.gameObject);
			} 
		}
	}
//	void OnCollisionStay2D(Collision2D col)
//	{
//		if (col.gameObject.tag == "Note") {
//			NoteButtonColliding = true;
//			Debug.Log("Colliding: " + NoteButtonColliding);
//		}
//	}
//
//	void OnCollisionExit2D(Collision2D col)
//	{
//		if (col.gameObject.tag == "Note") {
//			NoteButtonColliding = false;
//			Debug.Log("Colliding: " + NoteButtonColliding);
//		}
//	}
	
}
