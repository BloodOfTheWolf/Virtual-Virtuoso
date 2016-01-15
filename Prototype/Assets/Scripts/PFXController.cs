using UnityEngine;
using System.Collections;

public class PFXController : MonoBehaviour 
{
    public GameObject DistantPFX;   // asset containing the distant pfx
    public GameObject NearPFX;      // asset containing the near pfx
    GameObject distantObj = null;   // object container for distant pfx instance
    GameObject nearObj = null;      // object container for near pfx instance
    GameObject[] pfxObjs;           // array used for counting the number of spawned distant/near pfx instances

    // Spawns the 'distant' and 'near' background particle effects.
    public void SpawnObjects()
    {
        Debug.Log( "PFXController.SpawnObjects(): Entered" );

        if( pfxObjs.Length == 0)
        {
            distantObj = Instantiate( DistantPFX, new Vector3( 11, 0, 2 ), Quaternion.Euler( 0, -90, 90 ) ) as GameObject;
            DontDestroyOnLoad( distantObj );

            nearObj = Instantiate( NearPFX, new Vector3( 11, 0, 1 ), Quaternion.Euler( 0, -90, 90 ) ) as GameObject;
            DontDestroyOnLoad( nearObj );
        }
        else
        {
            Debug.Log( "PFXController.SpawnObjects(): Too many instances exist! Not spawning..." );
        }
    }

    // Force-spawns the 'distant' and 'near' background particle effects.
    public void ForceSpawnObjects()
    {
        Debug.Log( "PFXController.ForceSpawnObjects(): Entered" );

        distantObj = Instantiate( DistantPFX, new Vector3( 11, 0, 2 ), Quaternion.Euler( 0, -90, 90 ) ) as GameObject;
        DontDestroyOnLoad( distantObj );

        nearObj = Instantiate( NearPFX, new Vector3( 11, 0, 1 ), Quaternion.Euler( 0, -90, 90 ) ) as GameObject;
        DontDestroyOnLoad( nearObj );

        PlayEffects();
    }

    void Start()
    {
        Debug.Log( "PFXController.Start(): Entered" );

        DontDestroyOnLoad( gameObject );

        pfxObjs = GameObject.FindGameObjectsWithTag( "FrontEndNotesPFX" );
        
        SpawnObjects();
        PlayEffects();
    }

    // Plays the 'distant' and 'near' particle effects if a) they're not null, and b) they're not already playing.
    public void PlayEffects()
    {
        Debug.Log( "PFXController.PlayEffects(): Entered" );

        // are the objects legit
        if( (distantObj != null) && (nearObj != null) )
        {
            // are both particle effects not already playing
            if( !(distantObj.GetComponent<ParticleSystem>().isPlaying) && !(nearObj.GetComponent<ParticleSystem>().isPlaying) )
            {
                Debug.Log( "PFXController.PlayEffects(): Playing..." );
                distantObj.GetComponent<ParticleSystem>().Play();
                nearObj.GetComponent<ParticleSystem>().Play();
            }
        }
        else
        {
            Debug.Log( "PFXController.PlayEffects(): Objects are null, respawning" );
            SpawnObjects();
        }
    }

    // Stops and destroys the 'distant' and 'near' particle effects if they're playing.
    public void StopEffects()
    {
        Debug.Log( "PFXController.StopEffects(): Entered" );

        if( (distantObj.GetComponent<ParticleSystem>().isPlaying) && (nearObj.GetComponent<ParticleSystem>().isPlaying) )
        {
            Debug.Log( "PFXController.StopEffects(): Stopping and cleaning up particle effects" );

            distantObj.GetComponent<ParticleSystem>().Stop();
            distantObj.GetComponent<ParticleSystem>().Clear();
            Destroy( distantObj );

            nearObj.GetComponent<ParticleSystem>().Stop();
            nearObj.GetComponent<ParticleSystem>().Clear();
            Destroy( nearObj );
        }
        else
        {
            Debug.LogError( "PFXController.StopEffects(), ERROR: Particle effects reported not playing" );
        }
    }
}
