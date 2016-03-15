using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoadManager : MonoBehaviour
{
    /// <summary>
    /// Is the timer running?
    /// </summary>
    bool bTimerActive;

    /// <summary>
    /// Have the screen fade in? If not, pop it in.
    /// </summary>
    bool bDoFade;

    /// <summary>
    /// The duration of the fade in seconds.
    /// </summary>
    float FadeTimeValue = 0.5f;

    /// <summary>
    /// The UI object's alpha value at the beginning of the fade.
    /// </summary>
    float FadeBeginValue;

    /// <summary>
    /// The UI object's alpha value at the end of the fade.
    /// </summary>
    float FadeEndValue;

    public GameObject CanvasGroup;

    void Start()
    {
        DontDestroyOnLoad( this.gameObject );
        PullScreen();
    }

    void Update()
    {
        if( bTimerActive )
        {
            FadeTimeValue -= Time.deltaTime;
            CanvasGroup.GetComponent<CanvasGroup>().alpha = Mathf.Lerp( FadeEndValue, FadeBeginValue, FadeTimeValue );

            if( FadeTimeValue <= 0 )
            {
                bTimerActive = false;
            }
        }
    }

    /// <summary>
    /// Shows the load screen. If /doFade/ is true, fade in the screen over /fadeTime/. If /fadeTime/ isn't specified, default to 0.5f.
    /// </summary>
    /// <param name="doFade">Fade in the screen?</param>
    /// <param name="fadeTime">The duration of the fade.</param>
    public void PushScreen( float fadeTime )
    {
        Debug.Log( "LoadManager.PushScreen(): Entered" );
        this.GetComponent<Canvas>().enabled = true;

        FadeTimeValue = fadeTime;
        bTimerActive = true;
        FadeBeginValue = 0.0f;
        FadeEndValue = 1.0f;
    }

    /// <summary>
    /// Hides the load screen.
    /// </summary>
    public void PullScreen()
    {
        Debug.Log( "LoadManager.PullScreen(): Entered" );
        this.GetComponent<Canvas>().enabled = false;

        CanvasGroup.GetComponent<CanvasGroup>().alpha = 0.0f;

        FadeBeginValue = 0.0f;
        FadeEndValue = 1.0f;
    }
}
