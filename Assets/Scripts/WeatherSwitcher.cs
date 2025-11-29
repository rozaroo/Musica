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
