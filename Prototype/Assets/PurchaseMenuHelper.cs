using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PurchaseMenuHelper : MonoBehaviour
{
    public BGMusicSetController BGMusicControllerScript;

	void Start()
    {
        BGMusicControllerScript = GameObject.Find( "BGMusicController" ).GetComponent<BGMusicSetController>();
        BGMusicControllerScript.PurchaseMenu = gameObject.GetComponent<Canvas>();
	}
}
