using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Results_AcceptButtonScript : MonoBehaviour {

    GameObject SFXController;

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        SFXController = GameObject.Find( "SFXController" );	
	}

    public void ReturntoMainMenu()
    {
        SFXController.GetComponent<SFXControllerScript>().ButtonPressed();
        Application.LoadLevel( "MainMenu" );
    }
}
