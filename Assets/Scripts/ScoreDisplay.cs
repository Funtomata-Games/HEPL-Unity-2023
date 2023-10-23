using TMPro;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    public TMP_Text scoreText;

    private void Update()
    {
        scoreText.text = GameManager.score.ToString();
    }
}