using TMPro;
using UnityEngine;

public class DropdownTextTransfer : MonoBehaviour
{
    public TextMeshProUGUI targetText;
    public TMP_Dropdown dropdown;

    void Start()
    {
        
        dropdown.onValueChanged.AddListener(delegate { TransferText(dropdown); });
    }

    public void TransferText(TMP_Dropdown dropdown)
    {
        targetText.text = dropdown.options[dropdown.value].text;
        targetText.gameObject.SetActive(true);
    }
}
