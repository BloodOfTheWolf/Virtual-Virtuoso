using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Results_AcceptButtonScript : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ReturntoMainMenu()
    {
        Application.LoadLevel( "MainMenu" );
    }
}
