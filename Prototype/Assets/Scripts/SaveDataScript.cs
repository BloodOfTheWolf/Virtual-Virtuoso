using UnityEngine;
using System.Collections;

public class SaveDataScript : MonoBehaviour
{
    public bool bNoteAssistModeEnabled;

    // 0 = available, 1 = not available, 2 = purchased
    public int MusicSetOneState = 0;
    public int MusicSetTwoState = 0;
    public int MusicSetThreeState = 0;
    public int MusicSetFourState = 0;
    
    void Start()
    {
        DontDestroyOnLoad( this.gameObject );
        bNoteAssistModeEnabled = true;
    }
}
