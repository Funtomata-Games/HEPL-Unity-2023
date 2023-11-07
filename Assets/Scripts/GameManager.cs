using UnityEngine;
using UnityEngine.SceneManagement;

public static class GameManager
{
    public static void GameOver()
    {
        SceneManager.LoadScene(0);
    }
}