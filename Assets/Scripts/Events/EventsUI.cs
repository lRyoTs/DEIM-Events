using UnityEngine;
using TMPro;

public class EventsUI : MonoBehaviour
{
    #region VARIABLES

    [SerializeField] private TextMeshProUGUI distanceText;
    private string defaultText = "Distance to Enemy";

    #endregion

    private void Awake()
    {
        InitializeText();
        EventsGameManager.onEnterKeyPressed += UpdateText;
        EventsGameManager.onEscapeKeyPressed += InitializeText;
    }

    private void OnDisable()
    {
        EventsGameManager.onEnterKeyPressed -= UpdateText;
        EventsGameManager.onEscapeKeyPressed -= InitializeText;
    }

    private void InitializeText()
    {
        distanceText.text = defaultText;
    }

    private void UpdateText()
    {
        float distance = EventsPlayerController.Instance.DistanceToEnemy();
        distanceText.text = distance.ToString("F2");
    }
}
