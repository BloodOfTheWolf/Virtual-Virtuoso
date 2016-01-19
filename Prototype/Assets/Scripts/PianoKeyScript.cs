using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(AudioSource))]

public class PianoKeyScript : MonoBehaviour 
{

	AudioSource audio;
	public GameObject barnotes;
	GameObject LitNote;
	private float NoteVol;
	private GameObject Tutorial;
	private bool Colored;

	private List<GameObject> TouchList = new List<GameObject>();
	private GameObject[] OldTouches;

    //private Ray ray;
    private RaycastHit RayHitInfo = new RaycastHit();
   // public static int CurrTouch =0;

		// Use this for initialization
		void Awake () 
		{
			Colored = ColorToggleScript.Toggle;
			// only to be done once. not in update
		    audio = GetComponent<AudioSource>();
			NoteVol = PianoVolumeScript.PKVolume;
			audio.volume = NoteVol;

			Tutorial = gameObject.transform.GetChild (1).gameObject;
			if (Colored == false) 
			{
			Tutorial.SetActive(false);

			}
			LitNote = gameObject.transform.GetChild (0).gameObject;
			//notesHitBox = GameObject.FindWithTag(ajorHitbox)
		

		}
		
		// Update is called once per frame
		void Update ()
		{
            if(Input.touches.Length > 0)
            {
				OldTouches = new GameObject[TouchList.Count];
				TouchList.CopyTo(OldTouches);
				TouchList.Clear();
				foreach(Touch touch in Input.touches)
				{
				Ray ray = Camera.main.ScreenPointToRay(touch.position);

				if(Physics.Raycast(ray , out RayHitInfo ))
				{
					GameObject recipient = RayHitInfo.transform.gameObject;
					TouchList.Add(recipient);

					if( touch.phase == TouchPhase.Began)
					{
						recipient.SendMessage("OnTouchDown");
					}
					if( touch.phase == TouchPhase.Ended)
					{
						recipient.SendMessage("OnTouchUp");
					}
				}



				}

				foreach(GameObject g in OldTouches)
				{
					if(!TouchList.Contains(g))
					{
					g.SendMessage("OnTouchUp");

					}

				}
//                for(int i = 0; i < Input.touchCount ; i++)
//                {
//                    CurrTouch = i;
//                    if(Input.GetTouch(i).phase == TouchPhase.Began)
//                    {
//                        ray = Camera.main.ScreenPointToRay( Input.GetTouch( i ).position );
//                        if(Physics.Raycast(ray, out RayHitInfo))
//                        {
//							OnMouseDown();
//                        }
//                    }
//
//                    if(Input.GetTouch(i).phase == TouchPhase.Ended)
//                    {
//						OnMouseUp();
//                    }
//
//                }
            }
			
		}
		
	void OnMouseDown()
	{

			audio.Play ();
			barnotes.SetActive (true);
			LitNote.SetActive (true);
	}
	void OnMouseUp()
	{

		barnotes.SetActive(false);
		LitNote.SetActive(false);
	}

	void OnTouchDown()
	{
		
		audio.Play ();
		barnotes.SetActive (true);
		LitNote.SetActive (true);
	}
	void OnTouchUp()
	{
		
		barnotes.SetActive(false);
		LitNote.SetActive(false);
	}
		
	void OnTriggerEnter(Collider other)
	{
	}

}