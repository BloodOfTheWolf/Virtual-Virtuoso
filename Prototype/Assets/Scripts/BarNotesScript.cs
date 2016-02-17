using UnityEngine;
using System.Collections;

public class BarNotesScript : MonoBehaviour {

	//private Collider noteHitBox;


	// Use this for initialization
	void Start () 
	{
		//this.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () 
	{
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "SheetNote") 
		{
			this.gameObject.SetActive (false);
		}
	}
}
