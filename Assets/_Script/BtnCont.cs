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

    // Метод для скрытия панели
    public void HideButtons()
    {
      
        MainButton.SetActive(false);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
