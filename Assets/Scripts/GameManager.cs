using UnityEngine;
using UnityEngine.SceneManagement;

public static class GameManager
{
    public static int score;
    public static int hiScore;
    
    public static void GameOver()
    {
        hiScore = Mathf.Max(score, hiScore);
        PlayerPrefs.SetInt("HiScore", hiScore);
        SceneManager.LoadScene(0);
    }

    public static void NewGame()
    {
        hiScore = PlayerPrefs.GetInt("HiScore");
        score = 0;
        SceneManager.LoadScene("Game");
    }
}
