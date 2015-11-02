using UnityEngine;
using System.Collections;

public class LitkeyScript : MonoBehaviour {

	public Renderer rend;

	// Use this for initialization
	void Start () 
	{
		this.gameObject.SetActive (false);
		//rend = GetComponent<Renderer>();
		//rend.enabled = false;
		//print ("the key is off");
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
