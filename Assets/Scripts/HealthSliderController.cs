using UnityEngine;
using UnityEngine.UI;

public class HealthSliderController : MonoBehaviour
{
    public Slider healthSlider;
    public AK.Wwise.RTPC HealthRTPC;
    public GameObject RTPCEmitter; // Objeto que ejecuta el latido
    void Start()
    {
        // Setear valor inicial
        HealthRTPC.SetValue(RTPCEmitter, healthSlider.value);
        // Escuchar cambios del slider
        healthSlider.onValueChanged.AddListener(OnHealthChanged);
    }
    void OnHealthChanged(float value)
    {
        HealthRTPC.SetValue(RTPCEmitter, value);
        Debug.Log("Health = " + value);
    }
}
