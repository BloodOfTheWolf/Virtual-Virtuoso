using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerCashTextScript : MonoBehaviour
{
    //******************************************************//
    // AG 16-Feb-16                                         //
    //  NOTE: To view the CurrencyCanvas in the Boot scene, //
    //  enable its Canvas component and set its Sort Order  //
    //  to a value greater than or equal to 100.            //
    //******************************************************//

    /// <summary>
    /// The script storing the player's cash.
    /// </summary>
    public PlayerScoreInfoScript Cash;

    /// <summary>
    /// The text object displaying the player's cash.
    /// </summary>
    public GameObject TextObject;

    /// <summary>
    /// The text component of the text object displaying the player's cash.
    /// </summary>
    Text CashTextComponent;

    void Start()
    {
        // This is a persistent object
        DontDestroyOnLoad( this.gameObject );

        // Get and store the text object's text component
        CashTextComponent = TextObject.GetComponent<Text>();
    }

    void Update()
    {
        // Is the CurrencyCanvas visible?
        if( gameObject.GetComponent<Canvas>().enabled )
        {
            // Update the text with the player's current cash
            CashTextComponent.text = PlayerScoreInfoScript.PlayerMoney.ToString();
        }
    }

    /// <summary>
    /// Hides the CurrencyCanvas.
    /// </summary>
    public void HideCash()
    {
        gameObject.GetComponent<Canvas>().enabled = false;
    }

    /// <summary>
    /// Shows the CurrencyCanvas.
    /// </summary>
    public void ShowCash()
    {
        gameObject.GetComponent<Canvas>().enabled = true;
    }
}
