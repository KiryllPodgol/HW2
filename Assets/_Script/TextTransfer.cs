using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class TextTransfer : MonoBehaviour
{
    public TextMeshProUGUI targetText;

    public void TransferText(Button button)
    {
        if (button.name == "Disable")
        {
            targetText.gameObject.SetActive(false);
        }
        else
        {
            targetText.text = button.name;
            targetText.gameObject.SetActive(true);
        }
    }
}