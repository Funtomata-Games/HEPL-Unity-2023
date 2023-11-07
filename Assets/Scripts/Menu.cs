using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string gameSceneName;
    
    public void NewGame()
    {
        SceneManager.LoadScene(gameSceneName);
    }
    public void Options()
    {
        print("Options was clicked");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
