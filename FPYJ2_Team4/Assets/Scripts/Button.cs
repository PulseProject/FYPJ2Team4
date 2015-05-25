using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//With Collider but without RigidBody since its static
public class Button : MonoBehaviour {


	// Use this for initialization
	public bool touching = false;
	public int combo;
	public Text ComboCounter;
	public float myDistance;
	void Start () {
		combo = 0;
		ComboCounter.text = ""+combo;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("isTouching: " + isTouching());
	}


	bool isTouching()
	{
			RaycastHit2D hit = Physics2D.Raycast (transform.position, Vector2.up * myDistance);
			Debug.DrawRay (transform.position, Vector2.up * myDistance);
			if (Input.GetMouseButtonDown (0)) {
			if (hit.collider != null) {
				if (hit.collider.tag == "Note") {
					++combo;
					ComboCounter.text = ""+combo;
					Destroy (hit.collider.gameObject);
					return true;
				}
			}
			else{
				return false;
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
