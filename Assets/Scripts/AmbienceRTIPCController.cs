using UnityEngine;

public class AmbienceRTIPCController : MonoBehaviour
{
    [Header("Wwise Event (Ambiente)")]
    public AK.Wwise.Event PlayAmbienceEvent;

    [Header("RTPCs")]
    public AK.Wwise.RTPC BirdSoundsRTPC;
    public AK.Wwise.RTPC WindIntensityRTPC;

    [Header("RTPC Values")]
    [Range(0, 100)] public float birdIntensity = 50f;
    [Range(0, 100)] public float windIntensity = 50f;

    void Start()
    {
        // Reproducimos el ambiente general (jungla, viento, pájaros, etc.)
        PlayAmbienceEvent.Post(gameObject);
    }

    void Update()
    {
        // Enviamos los RTPCs cada frame
        BirdSoundsRTPC.SetValue(gameObject, birdIntensity);
        WindIntensityRTPC.SetValue(gameObject, windIntensity);
    }
}
