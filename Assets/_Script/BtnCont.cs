using Unity.VisualScripting;
using UnityEngine;

public class BtnCont : MonoBehaviour
{

   
    public GameObject Panel;
    public GameObject MainButton;
   



    public void ShowButtons()
    {
        Panel.SetActive(true);
      
    }

    // ����� ��� ������� ������
    public void HideButtons()
    {
      
        MainButton.SetActive(false);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
