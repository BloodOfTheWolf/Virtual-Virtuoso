using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuScript : MonoBehaviour {

	public Canvas quitMenu;
	public Button startText;
	public Button marketText;
	public Button optionsText;
	public Button exitText;

	// Use this for initialization
	void Start () {
	
		quitMenu = quitMenu.GetComponent<Canvas> ();
		startText = startText.GetComponent<Button> ();
		marketText = marketText.GetComponent<Button> ();
		optionsText = optionsText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
		quitMenu.enabled = false;

	}
	
	public void ExitButtonPress()
	{
		quitMenu.enabled = true;
		startText.enabled = false;
		marketText.enabled = false;
		optionsText.enabled = false;
		exitText.enabled = false;
	}

	public void NoButtonPress()
	{
		quitMenu.enabled = false;
		startText.enabled = true;
		marketText.enabled = true;
		optionsText.enabled = true;
		exitText.enabled = true;
	}

	public void GoToSongSelect()
	{
		Application.LoadLevel (1);
	}

	public void GameExit()
	{
		Application.Quit ();
	}
}
