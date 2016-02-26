using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FireworksScript : MonoBehaviour
{
    /// <summary>
    /// Is the timer running?
    /// </summary>
    bool bTimerActive;

    /// <summary>
    /// The base duration of the timer in seconds.
    /// </summary>
    public float TimerBaseValue = 1.0f;

    /// <summary>
    /// The timer's current value.
    /// </summary>
    float TimerCurValue;

    /// <summary>
    /// Asset containing the ParticleSystem.
    /// </summary>
    public GameObject ParticleSystemObject;

    /// <summary>
    /// Object container for the ParticleSystem instance.
    /// </summary>
    GameObject pfxInst = null;


    void Start()
    {
        Debug.Log( "FireworksScript.Start(): Entered" );

        TimerCurValue = TimerBaseValue;

        SpawnObjects();
        PlayEffects();

        StartTimer( TimerBaseValue );
    }

    void Update()
    {
        if( bTimerActive )
        {
            TimerCurValue -= Time.deltaTime;

            if( TimerCurValue <= 0 )
            {
                TimerElapse();
            }
        }
    }


    /// <summary>
    /// Call this to start the timer.
    /// </summary>
    /// <param name="duration">The duration of the timer in seconds.</param>
    void StartTimer( float duration )
    {
        bTimerActive = true;

        TimerCurValue = duration;
    }

    /// <summary>
    /// Call this to stop the timer. (duh)
    /// </summary>
    void StopTimer()
    {
        bTimerActive = false;
    }

    /// <summary>
    /// This is called when the timer elapses.
    /// </summary>
    void TimerElapse()
    {
        bTimerActive = false;

        //StopEffects();
        SpawnObjects();
        PlayEffects();

        StartTimer( 1.0f );
    }


    /// <summary>
    /// Spawns the particle effects.
    /// </summary>
    public void SpawnObjects()
    {
        Debug.Log( "FireworksScript.SpawnObjects(): Entered" );

        int xx, yy, zz;
        xx = Random.Range( -7, 7 );
        yy = Random.Range( -4, 4 );
        zz = Random.Range( -5, -5 );

        pfxInst = Instantiate( ParticleSystemObject, new Vector3( xx, yy, zz ), Quaternion.Euler( 0, 0, 0 ) ) as GameObject;
        Destroy( pfxInst, pfxInst.GetComponent<ParticleSystem>().duration );
    }

    /// <summary>
    /// Plays the particle effects if a) they're not null, and b) they're not already playing.
    /// </summary>
    public void PlayEffects()
    {
        Debug.Log( "FireworksScript.PlayEffects(): Entered" );

        // Is the object legit?
        if( pfxInst != null )
        {
            // Is the particle effect already playing
            if( !pfxInst.GetComponent<ParticleSystem>().isPlaying )
            {
                Debug.Log( "FireworksScript.PlayEffects(): Playing..." );
                pfxInst.GetComponent<ParticleSystem>().Play();
            }
        }
        else
        {
            Debug.Log( "FireworksScript.PlayEffects(): Objects are null, respawning" );
            SpawnObjects();
        }
    }

    /// <summary>
    /// Stops and destroys the particle effects if they're playing.
    /// </summary>
    public void StopEffects()
    {
        Debug.Log( "FireworksScript.StopEffects(): Entered" );

        if( pfxInst.GetComponent<ParticleSystem>().isPlaying )
        {
            Debug.Log( "FireworksScript.StopEffects(): Stopping and cleaning up particle effects" );

            pfxInst.GetComponent<ParticleSystem>().Stop();
            pfxInst.GetComponent<ParticleSystem>().Clear();
        }
        else
        {
            Debug.LogError( "FireworksScript.StopEffects(), ERROR: Particle effects reported not playing" );
        }
    }
}
