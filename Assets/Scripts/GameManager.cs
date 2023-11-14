using UnityEngine.SceneManagement;

public static class GameManager
{
    public static int score;

    public static void GameOver()
    {
        SceneManager.LoadScene(0);
    }
}