using UnityEngine;
using System.Collections;

public class SaveDataScript : MonoBehaviour
{
    public bool bNoteAssistModeEnabled;
    
    void Start()
    {
        DontDestroyOnLoad( this.gameObject );
        bNoteAssistModeEnabled = true;
    }
}
