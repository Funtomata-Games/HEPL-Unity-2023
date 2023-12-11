using UnityEngine;

public class Menu : MonoBehaviour
{
    public void OnPlayClicked()
    {
        GameManager.NewGame();
    }

    public void OnOptionsClicked()
    {
        print("Options clicked");
    }

    public void OnQuitClicked()
    {
        Application.Quit();
    }
}
