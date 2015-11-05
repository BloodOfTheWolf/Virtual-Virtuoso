using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TutorialControlScript : MonoBehaviour {
	
	public Canvas WelcomeCanvas;
	public Canvas PianoCanvas;
	public Canvas NotesCanvas;
	public Canvas PlaybarCanvas;
	public Canvas CorrectCanvas;
	public Canvas IncorrectCanvas;
	public Canvas CongratsCanvas;

	public GameObject TutorialControlOne;
	public GameObject TutorialControlTwo;
	public GameObject TutorialControlThree;
	public GameObject TutorialControlFour;
	public GameObject TutorialControlFive;
	public GameObject TempoBar;

	public int TimesOpened = 0;

	// Use this for initialization
	void Start () {
	
		WelcomeCanvas.enabled = false;
		PianoCanvas.enabled = false;
		NotesCanvas.enabled = false;
		PlaybarCanvas.enabled = false;
		CorrectCanvas.enabled = false;
		IncorrectCanvas.enabled = false;
		CongratsCanvas.enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
		//control when messages pop up
		if ((TutorialControlOne.transform.position.x <= TempoBar.transform.position.x)&&(TimesOpened == 0)) {
			WelcomeCanvas.enabled = true;
			Time.timeScale = 0;
			TimesOpened = 1;
		}

		if ((TutorialControlTwo.transform.position.x <= TempoBar.transform.position.x)&&(TimesOpened == 1)) {
			PianoCanvas.enabled = true;
			Time.timeScale = 0;
			TimesOpened = 2;
		}

		if ((TutorialControlThree.transform.position.x <= TempoBar.transform.position.x)&&(TimesOpened == 2)) {
			NotesCanvas.enabled = true;
			Time.timeScale = 0;
			TimesOpened = 3;
		}

		if ((TutorialControlFour.transform.position.x <= TempoBar.transform.position.x)&&(TimesOpened == 3)) {
			PlaybarCanvas.enabled = true;
			Time.timeScale = 0;
			TimesOpened = 4;
		}

		/*if (TutorialControlFive.transform.position.x <= TempoBar.transform.position.x) {
			CorrectCanvas.enabled = true;
			Time.timeScale = 0;
			GameObject.Destroy(TutorialControlFive);
		}*/

		/*if (TutorialControlSix.transform.position.x <= TempoBar.transform.position.x) {
			IncorrectCanvas.enabled = true;
			Time.timeScale = 0;
			GameObject.Destroy(TutorialControlSix);
		} */

		if ((TutorialControlFive.transform.position.x <= TempoBar.transform.position.x)&&(TimesOpened == 4)) {
			CongratsCanvas.enabled = true;
			Time.timeScale = 0;
			TimesOpened = 5;
		}
	}

		public void MenuClosed()
		{
			Time.timeScale = 1;
		if (TimesOpened == 1) {
			WelcomeCanvas.enabled = false;
		}
		if (TimesOpened == 2) {
			PianoCanvas.enabled = false;
		}
		if (TimesOpened == 3) {
			NotesCanvas.enabled = false;
		}
		if (TimesOpened == 4) {
			PlaybarCanvas.enabled = false;
		}
		if (TimesOpened == 5) {
			CongratsCanvas.enabled = false;
		}
		}

}
