using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class TimingBarScript : MonoBehaviour
{
    SheetNoteScript Sheet;
    List<GameObject> SheetNotes = new List<GameObject>();
    List<GameObject> FullBarNotes = new List<GameObject>();
    GameObject[] BarNotes;
    GameObject[] SharpBarNotes;

    public GameObject Perfect;
    public GameObject Great;
    public GameObject Good;
    public GameObject Miss;
    public GameObject Song;
    public GameObject LeftHand;

    
	// Use this for initialization
	void Start () 
    {
        BarNotes = GameObject.FindGameObjectsWithTag( "BarNote" );
        for( int i = 0; i < BarNotes.Length; i ++)
        {
            FullBarNotes.Add(BarNotes[i].gameObject);
            BarNotes[i].SetActive( false );
        }
        SharpBarNotes = GameObject.FindGameObjectsWithTag( "SharpBarNote" );
        for( int i = 0; i < SharpBarNotes.Length; i++ )
        {
            FullBarNotes.Add( SharpBarNotes[i].gameObject );
            SharpBarNotes[i].SetActive( false );
        }
       
        Perfect = GameObject.Find( "perfect_note_hit" );
        Perfect.SetActive( false );
        Great = GameObject.Find( "great_note_hit" );
        Great.SetActive( false );
        Good = GameObject.Find( "good_note_hit" );
        Good.SetActive( false );
        Miss = GameObject.Find( "miss_note_hit" );
        Miss.SetActive( false );
        Song = GameObject.FindGameObjectWithTag( "SongObject" );
        LeftHand = GameObject.FindGameObjectWithTag( "LeftHand" );
	}
	
	// Update is called once per frame
	void Update() 
    {
        CheckCollision();
        //print( "checking collision" );
	}

    void OnTriggerEnter( Collider other )
    {
        if( other.tag == "SheetNote" || other.tag == "SharpSheetNote" )
        {
            SheetNotes.Add( other.gameObject );
            print( "Added a  note" );     
        }
    }

    void OnTriggerExit( Collider other )
    {
        SheetNotes.Remove( other.gameObject );
        print( "Removed a  note" );
        other.gameObject.SetActive( false );
        Great.SetActive( false );
        Good.SetActive( false );
        Perfect.SetActive( false );
        if( other.tag == "SheetNote" || other.tag == "SharpSheetNote" )
        {
            Miss.SetActive( true );
            print( "triggerexit miss" );
            SheetNoteScript.Miss += 1;
        }
                        
    }

    void CheckCollision()
    {
        //print( BarNotes.Length );
        for( int i = 0; i < FullBarNotes.Count; i++ )
        {
           // print( "entered barnotes for loop" );
            if( FullBarNotes[i].activeSelf )
            {
                //print( "entered ifactive" );
                for( int j = 0; j < SheetNotes.Count; j++ )
                {
                   
                    //print( "entered sheetnotes for loop" );
                    if( FullBarNotes[i].transform.position.y < (SheetNotes[j].transform.position.y + 0.15f) && FullBarNotes[i].transform.position.y > (SheetNotes[j].transform.position.y - 0.15f) )
                    {
                        print( "barnote pos" + FullBarNotes[i].transform.position.y );
                        print( "sheetnote pos" + SheetNotes[j].transform.position.y );
                        //print( "entered sheetnotes  y check" );
                        float distance = Mathf.Abs( FullBarNotes[i].transform.position.x - SheetNotes[j].transform.position.x );
                        if(distance <= 0.2f) // Perfect
                        {
                            if( (FullBarNotes[i].gameObject.tag == "BarNote" && SheetNotes[j].gameObject.tag == "SheetNote") || (FullBarNotes[i].gameObject.tag == "SharpBarNote" && SheetNotes[j].gameObject.tag == "SharpSheetNote") )
                            {
                                Perfect.SetActive( true );
                                Good.SetActive( false );
                                Great.SetActive( false );
                                Miss.SetActive( false );
                                SheetNotes[j].SetActive( false );
                                SheetNotes.Remove( SheetNotes[j] );
                                SheetNoteScript.Score = SheetNoteScript.Score + 10;
                                print( "Score = " + SheetNoteScript.Score );
                                print( "perfect hit" );
                                SheetNoteScript.Hit += 1;
                                Song.GetComponent<MovementScript>().enabled = true;
                                LeftHand.GetComponent<MovementScript>().enabled = true;
                                Sheet.NotestreakMultiplierUpdate();
                            }

                        }
                        else if(distance <= 0.4f) // Great
                        {
                            if( (FullBarNotes[i].gameObject.tag == "BarNote" && SheetNotes[j].gameObject.tag == "SheetNote") || (FullBarNotes[i].gameObject.tag == "SharpBarNote" && SheetNotes[j].gameObject.tag == "SharpSheetNote") )
                            {
                                Great.SetActive( true );
                                Good.SetActive( false );
                                Perfect.SetActive( false );
                                Miss.SetActive( false );
                                SheetNotes[j].SetActive( false );
                                SheetNotes.Remove( SheetNotes[j] );
                                SheetNoteScript.Score = SheetNoteScript.Score + 8;
                                print( "Score = " + SheetNoteScript.Score );
                                print( "great hit" );
                                SheetNoteScript.Hit += 1;
                                Song.GetComponent<MovementScript>().enabled = true;
                                LeftHand.GetComponent<MovementScript>().enabled = true;
                                Sheet.NotestreakMultiplierUpdate();
                            }


                        }
                        else if(distance <= 0.6f) // Good
                        {
                            if( (FullBarNotes[i].gameObject.tag == "BarNote" && SheetNotes[j].gameObject.tag == "SheetNote") || (FullBarNotes[i].gameObject.tag == "SharpBarNote" && SheetNotes[j].gameObject.tag == "SharpSheetNote") )
                            {

                                Great.SetActive( false );
                                Good.SetActive( true );
                                Perfect.SetActive( false );
                                Miss.SetActive( false );
                                SheetNotes[j].SetActive( false );
                                SheetNotes.Remove( SheetNotes[j] );
                                SheetNoteScript.Score = SheetNoteScript.Score + 6;
                                print( "Score = " + SheetNoteScript.Score );
                                print( "good hit" );
                                SheetNoteScript.Hit += 1;
                                Song.GetComponent<MovementScript>().enabled = true;
                                LeftHand.GetComponent<MovementScript>().enabled = true;
                                Sheet.NotestreakMultiplierUpdate();
                            }
                        }
                    }
                }
            }
        }

    }
}
