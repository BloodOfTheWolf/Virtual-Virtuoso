using UnityEngine;
using System.Collections;

public class ParticleManager : MonoBehaviour 
{
    public GameObject expPrefab1;
    public GameObject expPrefab2;
    public GameObject expPrefab3;

    void Update()
    {
        // Burst-Sharp
        if( Input.GetKeyDown( "1" ) )
        {
            Instantiate( expPrefab1, new Vector3( 0, 0, 0 ), Quaternion.identity );
        }

        // Ring
        if( Input.GetKeyDown( "2" ) )
        {
            Instantiate( expPrefab2, new Vector3( 0, 0, 0 ), Quaternion.identity );
        }

        // Shockwave
        if( Input.GetKeyDown( "3" ) )
        {
            Instantiate( expPrefab3, new Vector3( 0, 0, 0 ), Quaternion.identity );
        }
    }
}
