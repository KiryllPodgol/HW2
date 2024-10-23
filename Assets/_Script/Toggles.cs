using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    public TextMeshProUGUI targetText;

    public void TransferText(Toggle toggle)
    {
        targetText.text = toggle.name;
        targetText.gameObject.SetActive(true);
    }
}
