using UnityEngine;

public class HeartbeatRTPC : MonoBehaviour
{
    public AK.Wwise.Event HeartEvent;     // Evento del corazón (Play_Heart)
    public AK.Wwise.RTPC HealthRTPC;      // Tu RTPC "Health"
    [Range(0, 100)]
    public float health = 100f;           // Variable simulada (podés enlazarla a tu sistema real)
    [Header("Input keys (configurables)")]
    public KeyCode decreaseKey = KeyCode.Q; // tecla para restar (mantener)
    public KeyCode increaseKey = KeyCode.E; // tecla para sumar (mantener)
    public float changeSpeed = 2f;         // cantidad por segundo que suma/resta

    void Start()
    {
        // Reproduce el Blend Container del corazón
        HeartEvent.Post(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        // ------ CONTROL DE HEALTH CON TECLAS ------
        if (Input.GetKey(decreaseKey)) health -= changeSpeed * Time.deltaTime;
        if (Input.GetKey(increaseKey)) health += changeSpeed * Time.deltaTime;
        // Limitar entre 0 y 100
        health = Mathf.Clamp(health, 0, 100);
        // Enviar RTPC a Wwise
        HealthRTPC.SetValue(gameObject, health);
    }
}
