using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TextFlasher : MonoBehaviour {

	//variables
	Text flashingStartText;
	public string textFlash;
	string blink = "";
	bool blinkSwitch = true;

	// Use this for initialization
	void Start () {
		flashingStartText = GetComponent<Text>();
		StartCoroutine(Blinking());
	}

	public IEnumerator Blinking(){
		while(blinkSwitch){
			flashingStartText.text = blink;
			yield return new WaitForSeconds(.5f);
			flashingStartText.text = textFlash;
			yield return new WaitForSeconds(.5f);
		}
	}

	/*// Update is called once per frame
	void Update () {
	
	}*/
}
