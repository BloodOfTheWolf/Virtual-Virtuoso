using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ColorToggleScript : MonoBehaviour {


    public static bool Toggle;
    Text DifficultySetting;
	// Use this for initialization
	void Start () 
    {
        DifficultySetting = this.gameObject.GetComponentInChildren<Text>();
        Toggle = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    public void OnClick()
    {
        if(Toggle == false)
        {
            Toggle = true;
            DifficultySetting.text = "Color Toggle ON";
            print( Toggle );
        }
        else
        {
            Toggle = false;
            DifficultySetting.text = "Color Toggle OFF";
            print( Toggle );
        }

    }
}
