using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InstrumentToggleScript : MonoBehaviour {


    public static bool FindToggle;
    public static int Instrument;
    
	// Use this for initialization
	void Start () 
    {
        CheckIntrumentsAvailable();
        ChangeInstrument(Instrument);
        ToggleSongIcon( Instrument );
	}
	
	public static void CheckIntrumentsAvailable()
    {
        if( SoundSetButtonController.InstrumentOneBought == false )
        {
            FindToggle = GameObject.Find( "DulcimerToggle" ).GetComponent<Toggle>().interactable = false;
        }
        else
        {
            FindToggle = GameObject.Find( "DulcimerToggle" ).GetComponent<Toggle>().interactable = true;
            
        }
        if( SoundSetButtonController.InstrumentTwoBought == false )
        {
            FindToggle = GameObject.Find( "HarpsichordToggle" ).GetComponent<Toggle>().interactable = false;
        }
        else
        {
            FindToggle = GameObject.Find( "HarpsichordToggle" ).GetComponent<Toggle>().interactable = true;
        }
        if( SoundSetButtonController.InstrumentThreeBought == false )
        {
            FindToggle = GameObject.Find( "OrganToggle" ).GetComponent<Toggle>().interactable = false;
        }
        else
        {
            FindToggle = GameObject.Find( "OrganToggle" ).GetComponent<Toggle>().interactable = true;
        }
       
    }

    public void ChangeInstrument(int i)
    {
        if(Instrument == 0)
        {
            Instrument = 1;
        }
        else
        {
        Instrument = i;

        }
        print( "Instrument number :" + Instrument );
    }

    public void ToggleSongIcon( int i )
    {
        switch( i )
        {
        case 1:
        FindToggle = GameObject.Find( "PianoToggle" ).GetComponent<Toggle>().isOn = true;
        break;
        case 2:
        FindToggle = GameObject.Find( "DulcimerToggle" ).GetComponent<Toggle>().isOn = true;
        break;
        case 3:
        FindToggle = GameObject.Find( "HarpsichordToggle" ).GetComponent<Toggle>().isOn = true;
        break;
        case 4:
        FindToggle = GameObject.Find( "OrganToggle" ).GetComponent<Toggle>().isOn = true;
        break;

        }
    }
}
