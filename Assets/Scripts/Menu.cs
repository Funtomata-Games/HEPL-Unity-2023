using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void OnPlayClicked()
    {
        SceneManager.LoadScene("Game");
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
