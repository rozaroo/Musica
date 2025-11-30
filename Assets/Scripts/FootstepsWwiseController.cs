using UnityEngine;
using AK.Wwise;
using StarterAssets;

[RequireComponent(typeof(CharacterController))]
public class FootstepsWwiseController : MonoBehaviour
{
    [Header("Wwise Events")]
    public AK.Wwise.Event FootstepEvent;
    public AK.Wwise.Event LandingEvent;

    [Header("Settings")]
    public float walkSpeedThreshold = 2f;
    public float runSpeedThreshold = 5f;
    public float walkStepInterval = 0.6f;
    public float runStepInterval = 0.35f;

    private CharacterController characterController;
    private FirstPersonController firstPersonController;
    private float stepTimer;
    private bool wasGroundedLastFrame;
    private bool wasMovingLastFrame;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
        firstPersonController = GetComponent<FirstPersonController>();
    }

    private void Update()
    {
        bool isGrounded = characterController.isGrounded;

        Vector3 horizontalVelocity = new Vector3(characterController.velocity.x, 0f, characterController.velocity.z);
        float speed = horizontalVelocity.magnitude;

        // --- Evitar pasos en el aire ---
        if (!isGrounded)
        {
            wasGroundedLastFrame = false;
            wasMovingLastFrame = false;
            return;
        }

        // --- Detectar aterrizaje ---
        if (isGrounded && !wasGroundedLastFrame)
        {
            LandingEvent.Post(gameObject);
        }

        wasGroundedLastFrame = isGrounded;

        // --- Sin movimiento ---
        if (speed < walkSpeedThreshold)
        {
            wasMovingLastFrame = false;
            stepTimer = 0f;
            return;
        }

        // --- Detectar inicio de movimiento ---
        if (!wasMovingLastFrame)
        {
            FootstepEvent.Post(gameObject); // ¡Primer paso instantáneo!
            stepTimer = 0f;                 // Reinicia el ciclo
        }

        wasMovingLastFrame = true;

        // --- Intervalo según caminar o correr ---
        float interval = (speed > runSpeedThreshold) ? runStepInterval : walkStepInterval;

        stepTimer += Time.deltaTime;

        if (stepTimer >= interval)
        {
            FootstepEvent.Post(gameObject);
            stepTimer = 0f;
        }

        // --- RTPC opcional de velocidad ---
        AkSoundEngine.SetRTPCValue("Player_Speed", speed, gameObject);
    }
}