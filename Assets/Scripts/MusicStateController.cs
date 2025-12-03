using UnityEngine;

public class MusicStateController : MonoBehaviour
{
    public AK.Wwise.Event PlayBGM;

    [Header("Wwise States")]
    public AK.Wwise.State ExploringState;
    public AK.Wwise.State InBattleState;
    
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
    }
}
