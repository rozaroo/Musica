using UnityEngine;

public class WeatherSwitcher : MonoBehaviour
{
    public AK.Wwise.Event PlayWeatherEvent;
    // Switches para asignar en el inspector
    public AK.Wwise.Switch SunnySwitch;
    public AK.Wwise.Switch RainSwitch;

    [Header("RTPCs")]
    public AK.Wwise.RTPC RainIntensityRTPC;  // RTPC de intensidad de lluvia

    [Range(0f, 100f)]
    public float rainIntensity = 0f;  // Control de intensidad

    private int stateIndex = 0;

    [Header("Input keys (configurables)")]
    public KeyCode decreaseKey = KeyCode.I; // tecla para restar (mantener)
    public KeyCode increaseKey = KeyCode.O; // tecla para sumar (mantener)
    public float changeSpeed = 2f;         // cantidad por segundo que suma/resta

    void Start()
    {
        rainIntensity = 50f; // Valor inicial
        // Empezamos reproduciendo el contenedor padre
        PlayWeatherEvent.Post(gameObject);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C)) ChangeWeather();
        // Enviar intensidad SOLO si estamos en estado Rain
        if (stateIndex == 1) RainIntensityRTPC.SetValue(gameObject, rainIntensity);
        // ------ CONTROL DE RAIN CON TECLAS ------
        if (Input.GetKey(decreaseKey)) rainIntensity -= changeSpeed * Time.deltaTime;
        if (Input.GetKey(increaseKey)) rainIntensity += changeSpeed * Time.deltaTime;
        // Limitar entre 0 y 100
        rainIntensity = Mathf.Clamp(rainIntensity, 0, 100);
    }
    void ChangeWeather()
    {
        stateIndex++;
        if (stateIndex > 2) stateIndex = 0;
        switch (stateIndex)
        {
            case 0:
                SunnySwitch.SetValue(gameObject);
                Debug.Log("Weather: Sunny");
                break;

            case 1:
                RainSwitch.SetValue(gameObject);
                Debug.Log("Weather: Rain");
                break;
        }
    }
}
