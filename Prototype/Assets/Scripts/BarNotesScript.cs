using UnityEngine;
using System.Collections;

public class BarNotesScript : MonoBehaviour
{
	//private Collider noteHitBox;

	void Start() 
	{
		//this.gameObject.SetActive (false);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "SheetNote") 
		{
			this.gameObject.SetActive (false);
            print( "object set inactive" );
		}
	}
}
