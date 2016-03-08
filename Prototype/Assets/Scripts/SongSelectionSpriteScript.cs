using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SongSelectionSpriteScript : MonoBehaviour {

    public Image TutorialSelected;
    public Image HotCrossSelected;
    public Image FurEliseSelected;
    public Image CanonSelected;
    public Image EntertainerSelected;

	void Start () 
    {
        TutorialSelected.enabled = true;
        HotCrossSelected.enabled = false;
        FurEliseSelected.enabled = false;
        CanonSelected.enabled = false;
        EntertainerSelected.enabled = false;
	}
	
	public void TutorialActive () 
    {
        TutorialSelected.enabled = true;
        HotCrossSelected.enabled = false;
        FurEliseSelected.enabled = false;
        CanonSelected.enabled = false;
        EntertainerSelected.enabled = false;
	}

    public void HotCrossActive()
    {
        TutorialSelected.enabled = false;
        HotCrossSelected.enabled = true;
        FurEliseSelected.enabled = false;
        CanonSelected.enabled = false;
        EntertainerSelected.enabled = false;
    }

    public void FurEliseActive()
    {
        TutorialSelected.enabled = false;
        HotCrossSelected.enabled = false;
        FurEliseSelected.enabled = true;
        CanonSelected.enabled = false;
        EntertainerSelected.enabled = false;
    }

    public void CanoninDSelected()
    {
        TutorialSelected.enabled = false;
        HotCrossSelected.enabled = false;
        FurEliseSelected.enabled = false;
        CanonSelected.enabled = true;
        EntertainerSelected.enabled = false;
    }

    public void TheEntertainerSelected()
    {
        TutorialSelected.enabled = false;
        HotCrossSelected.enabled = false;
        FurEliseSelected.enabled = false;
        CanonSelected.enabled = false;
        EntertainerSelected.enabled = true;
    }
}
