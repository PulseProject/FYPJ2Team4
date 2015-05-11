using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {
    public int whatbutton = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetButtonDown("1"))
        {
            if(whatbutton == 1)
            {
                //Red Button
            }
        }
        if (Input.GetButtonDown("2"))
        {
            if (whatbutton == 2)
            {
                //Blue Button
            }
        }
        if (Input.GetButtonDown("3"))
        {
            if (whatbutton == 3)
            {
                //Green Button
            }
        }
        if (Input.GetButtonDown("4"))
        {
            if (whatbutton == 4)
            {
                //Yellow Button
            }
        }
	}
}
