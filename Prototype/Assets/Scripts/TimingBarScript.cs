using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class TimingBarScript : MonoBehaviour
{

    List<GameObject> SheetNotes = new List<GameObject>();
    GameObject[] BarNotes;
    public GameObject Perfect;
    public GameObject Great;
    public GameObject Good;
    public GameObject Miss;
    public GameObject Song;
    public GameObject LeftHand;


	// Use this for initialization
	void Start () 
    {
        BarNotes = GameObject.FindGameObjectsWithTag("BarNote");
        for( int i = 0; i < BarNotes.Length; i ++)
        {
            BarNotes[i].SetActive( false );
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
        Miss.SetActive( true );
        print( "triggerexit miss" );
                        
    }

    void CheckCollision()
    {
        //print( BarNotes.Length );
        for( int i = 0; i < BarNotes.Length; i++ )
        {
           // print( "entered barnotes for loop" );
            if(BarNotes[i].activeSelf)
            {
                //print( "entered ifactive" );
                for( int j = 0; j < SheetNotes.Count; j++ )
                {
                   
                    //print( "entered sheetnotes for loop" );
                    if( BarNotes[i].transform.position.y < (SheetNotes[j].transform.position.y + 0.15f) && BarNotes[i].transform.position.y > (SheetNotes[j].transform.position.y - 0.15f) )
                    {
                        print( "barnote pos" + BarNotes[i].transform.position.y );
                        print( "sheetnote pos" + SheetNotes[j].transform.position.y );
                        //print( "entered sheetnotes  y check" );
                        float distance = Mathf.Abs(BarNotes[i].transform.position.x - SheetNotes[j].transform.position.x);
                        if(distance <= 0.2f) // Perfect
                        {
                            Perfect.SetActive( true );
                            Good.SetActive( false );
                            Great.SetActive( false );
                            Miss.SetActive( false );
                            SheetNotes[j].SetActive( false );
                            SheetNotes.Remove(SheetNotes[j]);
                            print( "perfect hit" );

                        }
                        else if(distance <= 0.4f) // Great
                        {
                            Great.SetActive( true );
                            Good.SetActive( false );
                            Perfect.SetActive( false );
                            Miss.SetActive( false );
                            SheetNotes[j].SetActive( false );
                            SheetNotes.Remove( SheetNotes[j] );
                            print( "great hit" );


                        }
                        else if(distance <= 0.6f) // Good
                        {
                            Great.SetActive( false );
                            Good.SetActive( true );
                            Perfect.SetActive( false );
                            Miss.SetActive( false );
                            SheetNotes[j].SetActive( false );
                            SheetNotes.Remove( SheetNotes[j] );
                            print( "good hit" );
                        }
                        Song.GetComponent<MovementScript>().enabled = true;
                        LeftHand.GetComponent<MovementScript>().enabled = true;
                        
                    }
                }
            }
        }

    }
}
