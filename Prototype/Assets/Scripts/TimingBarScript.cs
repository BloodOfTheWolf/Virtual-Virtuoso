using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class TimingBarScript : MonoBehaviour
{
    NoteStreakControllerScript Sheet;
    List<GameObject> SheetNotes = new List<GameObject>();
    List<GameObject> FullBarNotes = new List<GameObject>();
    GameObject[] BarNotes;
    GameObject[] SharpBarNotes;
    //GameObject[] NormalPositions;
    //GameObject[] SharpPositions;
    //NotePositionScript Position;

    public GameObject Perfect;
    public GameObject Great;
    public GameObject Good;
    public GameObject Miss;
    public GameObject Song;
    //public GameObject LeftHand;

    
	void Start() 
    {
        Sheet = GameObject.Find( "MultiplierCanvas" ).GetComponent<NoteStreakControllerScript>();

        BarNotes = GameObject.FindGameObjectsWithTag( "BarNote" );

        //NormalPositions = GameObject.FindGameObjectsWithTag( "SheetNote" );
        //SharpPositions = GameObject.FindGameObjectsWithTag( "SharpSheetNote" );

        //if(NormalPositions != null)
        //{
        //    for(int i = 0; i < NormalPositions.Length ; i++)
        //    {
        //        NormalPositions[i].SendMessage( "AdjustNotePosition" );
        //        print( "Position adjusted" );
        //    }
        //}

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
        //LeftHand = GameObject.FindGameObjectWithTag( "LeftHand" );
        
	}
	

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
            //print( "Added a  note" );     
        }
    }


    void OnTriggerExit( Collider other )
    {
        SheetNotes.Remove( other.gameObject );
       // print( "Removed a  note" );
        other.gameObject.SetActive( false );
        Great.SetActive( false );
        Good.SetActive( false );
        Perfect.SetActive( false );
        if( other.tag == "SheetNote" || other.tag == "SharpSheetNote" )
        {
            Miss.SetActive( true );
            print( "triggerexit miss" );
            Sheet.MissNote();
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
                        //print( "barnote pos" + FullBarNotes[i].transform.position.y );
                        //print( "sheetnote pos" + SheetNotes[j].transform.position.y );
                        //print( "entered sheetnotes  y check" );
                        float distance = Mathf.Abs( FullBarNotes[i].transform.position.x - SheetNotes[j].transform.position.x );
                        if(distance <= 0.2f) // Perfect
                        {
                            if( (FullBarNotes[i].gameObject.tag == "BarNote" && SheetNotes[j].gameObject.tag == "SheetNote") || (FullBarNotes[i].gameObject.tag == "SharpBarNote" && SheetNotes[j].gameObject.tag == "SharpSheetNote") )
                            {
                                Perfect.SetActive( true );
                                Good.SetActive( false );
                                Great.SetActive( false );
                                Miss.SetActive(false);
                                SheetNotes[j].GetComponent<SheetNoteScript>().HitNote();
                                SheetNotes[j].SetActive( false );
                                SheetNotes.Remove( SheetNotes[j] );
                                NoteStreakControllerScript.Score = NoteStreakControllerScript.Score + 10;
                                print( "Score = " + NoteStreakControllerScript.Score );
                                print( "perfect hit" );
                                Song.GetComponent<MovementScript>().enabled = true;
                                //LeftHand.GetComponent<MovementScript>().enabled = true;
                                Sheet.HitNote();
                                FullBarNotes[i].SetActive( false );
                            }

                        }
                        else if(distance <= 0.4f) // Great
                        {
                            if( (FullBarNotes[i].gameObject.tag == "BarNote" && SheetNotes[j].gameObject.tag == "SheetNote") || (FullBarNotes[i].gameObject.tag == "SharpBarNote" && SheetNotes[j].gameObject.tag == "SharpSheetNote") )
                            {
                                Great.SetActive( true );
                                Good.SetActive( false );
                                Perfect.SetActive( false );
                                Miss.SetActive(false);
                                SheetNotes[j].GetComponent<SheetNoteScript>().HitNote();
                                SheetNotes[j].SetActive( false );
                                SheetNotes.Remove( SheetNotes[j] );
                                NoteStreakControllerScript.Score = NoteStreakControllerScript.Score + 8;
                                print( "Score = " + NoteStreakControllerScript.Score );
                                print( "great hit" );
                                Song.GetComponent<MovementScript>().enabled = true;
                                //LeftHand.GetComponent<MovementScript>().enabled = true;
                                Sheet.HitNote();
                                FullBarNotes[i].SetActive( false );
                            }


                        }
                        else if(distance <= 0.6f) // Good
                        {
                            if( (FullBarNotes[i].gameObject.tag == "BarNote" && SheetNotes[j].gameObject.tag == "SheetNote") || (FullBarNotes[i].gameObject.tag == "SharpBarNote" && SheetNotes[j].gameObject.tag == "SharpSheetNote") )
                            {

                                Great.SetActive( false );
                                Good.SetActive( true );
                                Perfect.SetActive( false );
                                Miss.SetActive(false);
                                SheetNotes[j].GetComponent<SheetNoteScript>().HitNote();
                                SheetNotes[j].SetActive( false );
                                SheetNotes.Remove( SheetNotes[j] );
                                NoteStreakControllerScript.Score = NoteStreakControllerScript.Score + 6;
                                print( "Score = " + NoteStreakControllerScript.Score );
                                print( "good hit" );
                                Song.GetComponent<MovementScript>().enabled = true;
                                //LeftHand.GetComponent<MovementScript>().enabled = true;
                                Sheet.HitNote();
                                FullBarNotes[i].SetActive( false );
                            }
                        }
                    }
                }
            }
        }

    }
}
