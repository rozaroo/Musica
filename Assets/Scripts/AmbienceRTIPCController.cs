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

    [Header("Input keys (configurables)")]
    public KeyCode decreaseKey = KeyCode.R; // tecla para restar (mantener)
    public KeyCode increaseKey = KeyCode.T; // tecla para sumar (mantener)
    public float changeSpeed = 2f;         // cantidad por segundo que suma/resta

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
        // ------ CONTROL DE HEALTH CON TECLAS ------
        if (Input.GetKey(decreaseKey))
        {
            birdIntensity -= changeSpeed * Time.deltaTime;
            windIntensity -= changeSpeed * Time.deltaTime;
        }
        if (Input.GetKey(increaseKey))
        {
            birdIntensity += changeSpeed * Time.deltaTime;
            windIntensity += changeSpeed * Time.deltaTime;
        }
        // Limitar entre 0 y 100
        birdIntensity = Mathf.Clamp(birdIntensity, 0, 100);
        windIntensity = Mathf.Clamp(windIntensity, 0, 100);
    }
}
