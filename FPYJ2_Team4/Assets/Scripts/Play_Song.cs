using UnityEngine;
using System.Collections;

public class Play_Song : MonoBehaviour 
{
    public GameObject Red;
    public GameObject Blue;
    public GameObject Yellow;
    public GameObject Green;
    public int part = 0;
	// Use this for initialization
	void Update () 
    {
        if (part == 0)
        {
            SongStart();
            return;
        }
	}
    IEnumerator NoteDelay(float a)
    {
        a = 0;
        yield return new WaitForSeconds(a);
    }
	// Update is called once per frame
	void SongStart () 
    {
        Instantiate(Red, new Vector3(-1.5f, 0, 0), Quaternion.identity);
        StartCoroutine(NoteDelay(1));
        part += 1;
       // return;
	}
}
