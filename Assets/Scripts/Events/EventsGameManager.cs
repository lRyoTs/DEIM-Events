using Unity.VisualScripting;
using UnityEngine;

public class EventsGameManager : MonoBehaviour
{
    public delegate void OnEnterKeyPressed();
    public static OnEnterKeyPressed onEnterKeyPressed;
    // HERE YOU WILL HAVE TO DECLARE AND INVOKE THE EVENTS
    public delegate void OnEscapeKeyPressed();
    public static OnEscapeKeyPressed onEscapeKeyPressed;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) {
            if (onEnterKeyPressed != null) {
                onEnterKeyPressed();
            }
            
        }

        if (Input.GetKeyUp(KeyCode.Escape)) {
            if (onEscapeKeyPressed != null) {
                onEscapeKeyPressed();
            }
            
        }
    }
}
