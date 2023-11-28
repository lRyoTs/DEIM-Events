using UnityEngine;

public class EventsSFX : MonoBehaviour
{
    #region VARIABLES

    [SerializeField] private ParticleSystem particleSystem;

    #endregion

    private void Awake()
    {
        StopParticleSystem();
        EventsGameManager.onEnterKeyPressed += StartParticleSystem;
        EventsGameManager.onEscapeKeyPressed += StopParticleSystem;
    }

    private void OnDisable()
    {
        EventsGameManager.onEnterKeyPressed -= StartParticleSystem;
        EventsGameManager.onEscapeKeyPressed -= StopParticleSystem;
    }

    private void StartParticleSystem()
    {
        particleSystem.Play();
    }
    
    private void StopParticleSystem()
    {
        particleSystem.Stop();
    }
}
