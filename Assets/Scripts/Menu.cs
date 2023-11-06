using UnityEngine;

public class Menu : MonoBehaviour
{
    public string startScene;

    public void StartGame()
    {
        GameManager.NewGame(startScene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}