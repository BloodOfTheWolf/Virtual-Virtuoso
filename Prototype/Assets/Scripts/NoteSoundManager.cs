using UnityEngine;
using System.Collections;

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

public class NoteSoundManager : MonoBehaviour
{

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

        ChangeInstrument( CurrentInstrument );
    }

    /// <summary>
    /// Activates the instrument sound set based on /newInstrument/.
    /// </summary>
    /// <param name="newInstrument">The instrument sound set to activate.</param>
    public void ChangeInstrument( Instruments newInstrument )
    {
        CurrentInstrument = newInstrument;

        switch( CurrentInstrument )
        {
        case Instruments.Piano:
            C1 = Piano_C1;
            D1 = Piano_D1;
            E1 = Piano_E1;
            F1 = Piano_F1;
            G1 = Piano_G1;
            A2 = Piano_A2;
            B2 = Piano_B2;
            C2 = Piano_C2;
            D2 = Piano_D2;
            E2 = Piano_E2;
            F2 = Piano_F2;
            G2 = Piano_G2;
            A3 = Piano_A3;
            B3 = Piano_B3;

            C1_Sharp = Piano_C1_Sharp;
            D1_Sharp = Piano_D1_Sharp;
            F1_Sharp = Piano_F1_Sharp;
            G1_Sharp = Piano_G1_Sharp;
            A2_Sharp = Piano_A2_Sharp;
            C2_Sharp = Piano_C2_Sharp;
            D2_Sharp = Piano_D2_Sharp;
            F2_Sharp = Piano_F2_Sharp;
            G2_Sharp = Piano_G2_Sharp;
            A3_Sharp = Piano_A3_Sharp;
        break;
        case Instruments.Dulcimer:
            C1 = Dulcimer_C1;
            D1 = Dulcimer_D1;
            E1 = Dulcimer_E1;
            F1 = Dulcimer_F1;
            G1 = Dulcimer_G1;
            A2 = Dulcimer_A2;
            B2 = Dulcimer_B2;
            C2 = Dulcimer_C2;
            D2 = Dulcimer_D2;
            E2 = Dulcimer_E2;
            F2 = Dulcimer_F2;
            G2 = Dulcimer_G2;
            A3 = Dulcimer_A3;
            B3 = Dulcimer_B3;

            C1_Sharp = Dulcimer_C1_Sharp;
            D1_Sharp = Dulcimer_D1_Sharp;
            F1_Sharp = Dulcimer_F1_Sharp;
            G1_Sharp = Dulcimer_G1_Sharp;
            A2_Sharp = Dulcimer_A2_Sharp;
            C2_Sharp = Dulcimer_C2_Sharp;
            D2_Sharp = Dulcimer_D2_Sharp;
            F2_Sharp = Dulcimer_F2_Sharp;
            G2_Sharp = Dulcimer_G2_Sharp;
            A3_Sharp = Dulcimer_A3_Sharp;
        break;
        case Instruments.Harpsichord:
            C1 = Harpsichord_C1;
            D1 = Harpsichord_D1;
            E1 = Harpsichord_E1;
            F1 = Harpsichord_F1;
            G1 = Harpsichord_G1;
            A2 = Harpsichord_A2;
            B2 = Harpsichord_B2;
            C2 = Harpsichord_C2;
            D2 = Harpsichord_D2;
            E2 = Harpsichord_E2;
            F2 = Harpsichord_F2;
            G2 = Harpsichord_G2;
            A3 = Harpsichord_A3;
            B3 = Harpsichord_B3;

            C1_Sharp = Harpsichord_C1_Sharp;
            D1_Sharp = Harpsichord_D1_Sharp;
            F1_Sharp = Harpsichord_F1_Sharp;
            G1_Sharp = Harpsichord_G1_Sharp;
            A2_Sharp = Harpsichord_A2_Sharp;
            C2_Sharp = Harpsichord_C2_Sharp;
            D2_Sharp = Harpsichord_D2_Sharp;
            F2_Sharp = Harpsichord_F2_Sharp;
            G2_Sharp = Harpsichord_G2_Sharp;
            A3_Sharp = Harpsichord_A3_Sharp;
        break;
        case Instruments.PipeOrgan:
            C1 = PipeOrgan_C1;
            D1 = PipeOrgan_D1;
            E1 = PipeOrgan_E1;
            F1 = PipeOrgan_F1;
            G1 = PipeOrgan_G1;
            A2 = PipeOrgan_A2;
            B2 = PipeOrgan_B2;
            C2 = PipeOrgan_C2;
            D2 = PipeOrgan_D2;
            E2 = PipeOrgan_E2;
            F2 = PipeOrgan_F2;
            G2 = PipeOrgan_G2;
            A3 = PipeOrgan_A3;
            B3 = PipeOrgan_B3;

            C1_Sharp = PipeOrgan_C1_Sharp;
            D1_Sharp = PipeOrgan_D1_Sharp;
            F1_Sharp = PipeOrgan_F1_Sharp;
            G1_Sharp = PipeOrgan_G1_Sharp;
            A2_Sharp = PipeOrgan_A2_Sharp;
            C2_Sharp = PipeOrgan_C2_Sharp;
            D2_Sharp = PipeOrgan_D2_Sharp;
            F2_Sharp = PipeOrgan_F2_Sharp;
            G2_Sharp = PipeOrgan_G2_Sharp;
            A3_Sharp = PipeOrgan_A3_Sharp;
        break;
        }
    }
}
