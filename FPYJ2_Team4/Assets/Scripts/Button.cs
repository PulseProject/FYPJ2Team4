using UnityEngine;
using System.Collections;

//With Collider but without RigidBody since its static
public class Button : MonoBehaviour {


	// Use this for initialization
	
	public bool touching = false;
	public float myDistance;
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("isTouching: " + isTouching());
	}


	bool isTouching()
	{
		RaycastHit2D hit = Physics2D.Raycast (transform.position, Vector2.up * myDistance);
		Debug.DrawRay (transform.position, Vector2.up * myDistance);
		
		if (hit.collider != null) {
			if (hit.collider.tag == "Note") {
				return true;
			}
		}
		return false;
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
