using UnityEngine;
using System.Collections;

public class FrontEndBackgroundScript : MonoBehaviour
{
    public int MatIndex = 0;
    public Vector2 ScrollRate = new Vector2( 1.0f, 0.0f );
    public string TexName = "_MainTex";
    public Renderer rend;
    Vector2 uvOffset = Vector2.zero;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void LateUpdate()
    {
        uvOffset += (ScrollRate * Time.deltaTime);
        if( rend.enabled )
        {
            rend.materials[MatIndex].SetTextureOffset( TexName, uvOffset );
        }
    }
}
