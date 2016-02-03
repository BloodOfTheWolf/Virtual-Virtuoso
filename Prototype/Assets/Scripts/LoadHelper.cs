using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoadHelper : MonoBehaviour
{
    GameObject LoadManagerObject;

	void Start()
    {
        LoadManagerObject = GameObject.Find( "LoadManager" );
        LoadManagerObject.GetComponent<LoadManager>().PullScreen();
	}
}
