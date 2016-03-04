using UnityEngine;
using System.Collections;

public class NoteSoundManager : MonoBehaviour
{
    /// <summary>
    /// All available instruments to choose from.
    /// </summary>
    public enum Instruments
    {
        Piano,
        Dulcimer,
        Harpsichord,
        PipeOrgan
    };

    /// <summary>
    /// The instrument that is currently active.
    /// </summary>
    public Instruments CurrentInstrument = Instruments.Piano;

    public AudioClip C1;
    public AudioClip D1;
    public AudioClip E1;
    public AudioClip F1;
    public AudioClip G1;
    public AudioClip A2;
    public AudioClip B2;
    public AudioClip C2;
    public AudioClip D2;
    public AudioClip E2;
    public AudioClip F2;
    public AudioClip G2;
    public AudioClip A3;
    public AudioClip B3;

    public AudioClip C1_Sharp;
    public AudioClip D1_Sharp;
    public AudioClip F1_Sharp;
    public AudioClip G1_Sharp;
    public AudioClip A2_Sharp;
    public AudioClip C2_Sharp;
    public AudioClip D2_Sharp;
    public AudioClip F2_Sharp;
    public AudioClip G2_Sharp;
    public AudioClip A3_Sharp;

    public AudioClip Piano_C1;
    public AudioClip Piano_D1;
    public AudioClip Piano_E1;
    public AudioClip Piano_F1;
    public AudioClip Piano_G1;
    public AudioClip Piano_A2;
    public AudioClip Piano_B2;
    public AudioClip Piano_C2;
    public AudioClip Piano_D2;
    public AudioClip Piano_E2;
    public AudioClip Piano_F2;
    public AudioClip Piano_G2;
    public AudioClip Piano_A3;
    public AudioClip Piano_B3;

    public AudioClip Piano_C1_Sharp;
    public AudioClip Piano_D1_Sharp;
    public AudioClip Piano_F1_Sharp;
    public AudioClip Piano_G1_Sharp;
    public AudioClip Piano_A2_Sharp;
    public AudioClip Piano_C2_Sharp;
    public AudioClip Piano_D2_Sharp;
    public AudioClip Piano_F2_Sharp;
    public AudioClip Piano_G2_Sharp;
    public AudioClip Piano_A3_Sharp;

    public AudioClip Dulcimer_C1;
    public AudioClip Dulcimer_D1;
    public AudioClip Dulcimer_E1;
    public AudioClip Dulcimer_F1;
    public AudioClip Dulcimer_G1;
    public AudioClip Dulcimer_A2;
    public AudioClip Dulcimer_B2;
    public AudioClip Dulcimer_C2;
    public AudioClip Dulcimer_D2;
    public AudioClip Dulcimer_E2;
    public AudioClip Dulcimer_F2;
    public AudioClip Dulcimer_G2;
    public AudioClip Dulcimer_A3;
    public AudioClip Dulcimer_B3;

    public AudioClip Dulcimer_C1_Sharp;
    public AudioClip Dulcimer_D1_Sharp;
    public AudioClip Dulcimer_F1_Sharp;
    public AudioClip Dulcimer_G1_Sharp;
    public AudioClip Dulcimer_A2_Sharp;
    public AudioClip Dulcimer_C2_Sharp;
    public AudioClip Dulcimer_D2_Sharp;
    public AudioClip Dulcimer_F2_Sharp;
    public AudioClip Dulcimer_G2_Sharp;
    public AudioClip Dulcimer_A3_Sharp;

    public AudioClip Harpsichord_C1;
    public AudioClip Harpsichord_D1;
    public AudioClip Harpsichord_E1;
    public AudioClip Harpsichord_F1;
    public AudioClip Harpsichord_G1;
    public AudioClip Harpsichord_A2;
    public AudioClip Harpsichord_B2;
    public AudioClip Harpsichord_C2;
    public AudioClip Harpsichord_D2;
    public AudioClip Harpsichord_E2;
    public AudioClip Harpsichord_F2;
    public AudioClip Harpsichord_G2;
    public AudioClip Harpsichord_A3;
    public AudioClip Harpsichord_B3;

    public AudioClip Harpsichord_C1_Sharp;
    public AudioClip Harpsichord_D1_Sharp;
    public AudioClip Harpsichord_F1_Sharp;
    public AudioClip Harpsichord_G1_Sharp;
    public AudioClip Harpsichord_A2_Sharp;
    public AudioClip Harpsichord_C2_Sharp;
    public AudioClip Harpsichord_D2_Sharp;
    public AudioClip Harpsichord_F2_Sharp;
    public AudioClip Harpsichord_G2_Sharp;
    public AudioClip Harpsichord_A3_Sharp;

    public AudioClip PipeOrgan_C1;
    public AudioClip PipeOrgan_D1;
    public AudioClip PipeOrgan_E1;
    public AudioClip PipeOrgan_F1;
    public AudioClip PipeOrgan_G1;
    public AudioClip PipeOrgan_A2;
    public AudioClip PipeOrgan_B2;
    public AudioClip PipeOrgan_C2;
    public AudioClip PipeOrgan_D2;
    public AudioClip PipeOrgan_E2;
    public AudioClip PipeOrgan_F2;
    public AudioClip PipeOrgan_G2;
    public AudioClip PipeOrgan_A3;
    public AudioClip PipeOrgan_B3;

    public AudioClip PipeOrgan_C1_Sharp;
    public AudioClip PipeOrgan_D1_Sharp;
    public AudioClip PipeOrgan_F1_Sharp;
    public AudioClip PipeOrgan_G1_Sharp;
    public AudioClip PipeOrgan_A2_Sharp;
    public AudioClip PipeOrgan_C2_Sharp;
    public AudioClip PipeOrgan_D2_Sharp;
    public AudioClip PipeOrgan_F2_Sharp;
    public AudioClip PipeOrgan_G2_Sharp;
    public AudioClip PipeOrgan_A3_Sharp;

    void Start()
    {
        DontDestroyOnLoad( this.gameObject );
    }

    public void ChangeInstrument( Instruments newInstrument )
    {
        CurrentInstrument = newInstrument;
    }

    public Instruments GetCurrentInstrument()
    {
        return CurrentInstrument;
    }

}
