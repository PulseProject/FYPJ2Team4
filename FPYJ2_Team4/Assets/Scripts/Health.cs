using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Health : MonoBehaviour {
	public RaycastHit2D hit;
	public float myDistance;
	public Text health;
	public int hp;
	// Use this for initialization
	void Start () {
		hp = 10;
		health.text = "health :" + hp;
		hit = Physics2D.Raycast (transform.position, Vector2.up * myDistance);
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("isDestroyed: " + isTouching());
	}

	bool isTouching()
	{
		Debug.DrawRay (transform.position, Vector2.up * myDistance);
		if (hit.collider != null && hit.collider.tag == "Note") {
				--hp;
				health.text = "health :" + hp;
				Destroy(hit.collider.gameObject);
				return true;
		}
		return false;
	}
}
