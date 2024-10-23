using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class NewMonoBehaviourScript : MonoBehaviour
{
    public Button ButtonDisable;
    public Button[] buttonsToToggle;
    public TextMeshProUGUI targetText;
    private bool areButtonsActive = true;

    void Start()
    {
        ButtonDisable.onClick.AddListener(ToggleAllButtons);
    }

    void ToggleAllButtons()
    {
        areButtonsActive = !areButtonsActive;

        foreach (Button btn in buttonsToToggle)
        {
            btn.interactable = areButtonsActive;
        }

        targetText.gameObject.SetActive(areButtonsActive);
    }
}
