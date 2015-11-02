using UnityEngine;
using System.Collections;

public class CheckScript : MonoBehaviour {

	GameObject Checkmarks;
	// Use this for initialization
	void Start () 
	{
		this.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void SetGreenTrue()
	{
		Checkmarks = GameObject.FindGameObjectWithTag ("Right");
		Checkmarks.SetActive (true);
	}

	public void SetRedTrue()
	{
		Checkmarks = GameObject.FindGameObjectWithTag ("Wrong");
		Checkmarks.SetActive (true);
	}
}
