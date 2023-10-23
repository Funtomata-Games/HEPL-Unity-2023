using System;
using UnityEngine.SceneManagement;

public static class GameManager
{
    public const string MenuSceneName = "Menu";
    public static int score;
    
    public static void GameOver()
    {
        SceneManager.LoadScene(MenuSceneName);
    }

    public static void NewGame()
    {
        score = 0;
    }
}