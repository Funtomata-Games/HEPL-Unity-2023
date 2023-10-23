using UnityEngine;

public class ScoreOnDeath : MonoBehaviour
{
    private void OnDestroy()
    {
        GameManager.score++;
    }
}