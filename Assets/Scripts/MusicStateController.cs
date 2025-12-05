using UnityEngine;

public class MusicStateController : MonoBehaviour
{
    public AK.Wwise.Event PlayBGM;

    [Header("Wwise States")]
    public AK.Wwise.State ExploringState;
    public AK.Wwise.State InBattleState;

    private bool musicOn = true;   // Estado actual de la música

    private void Start()
    {
        // Reproducimos la BGM al comenzar
        PlayBGM.Post(gameObject);

        // Forzamos estado inicial
        ExploringState.SetValue();
        Debug.Log("Music State: Exploring");
    }

    private void Update()
    {
        // Cambiar a Exploring
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ExploringState.SetValue();
            Debug.Log("Music State: Exploring");
        }

        // Cambiar a InBattle
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            InBattleState.SetValue();
            Debug.Log("Music State: InBattle");
        }
        // ----------- Encender / Apagar música -----------
        if (Input.GetKeyDown(KeyCode.M)) ToggleMusic();
    }
    private void ToggleMusic()
    {
        musicOn = !musicOn;

        if (musicOn)
        {
            PlayBGM.Post(gameObject);
            Debug.Log("Music ON");
        }
        else
        {
            // Detiene la música del evento PlayBGM
            AkSoundEngine.ExecuteActionOnEvent(
                PlayBGM.Id,
                AkActionOnEventType.AkActionOnEventType_Stop,
                gameObject
            );

            Debug.Log("Music OFF");
        }
    }
}
