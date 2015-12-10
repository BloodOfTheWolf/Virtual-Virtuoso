using UnityEngine;
using System.Collections;

public class BarDividerScript : MonoBehaviour {

	public static int BarNumber;
	// Use this for initialization
	void Start () 
	{
		BarNumber = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Bar")
		{
			BarNumber = BarNumber +1;
			print("Barnumber collided: " + BarNumber);
		}

	}
}
